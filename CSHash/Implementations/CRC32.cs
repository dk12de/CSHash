using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CSHash.Implementations
{
    public class CRC32 : System.Security.Cryptography.HashAlgorithm
    {
        public const UInt32 defPolyn = 0xedb88320u;
        public const UInt32 defSeed = 0xffffffffu;

        static UInt32[] defaultTable;

        readonly UInt32 seed;
        readonly UInt32[] tbl;
        UInt32 hash;

        public CRC32()
            : this(defPolyn, defSeed)
        {
        }

        public CRC32(UInt32 polyn, UInt32 seed)
        {
            tbl = InitializeTable(polyn);
            this.seed = hash = seed;
        }

        public override void Initialize()
        {
            hash = seed;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            hash = CalculateHash(tbl, hash, array, ibStart, cbSize);
        }

        protected override byte[] HashFinal()
        {
            Tools.Converter converter = new Tools.Converter();
            var hBuffer = converter.UInt32ToBigEndian(~hash);
            HashValue = hBuffer;
            return hBuffer;
        }

        public override int HashSize { get { return 32; } }

        public static UInt32 Compute(byte[] buf)
        {
            return Compute(defSeed, buf);
        }

        public static UInt32 Compute(UInt32 seed, byte[] buf)
        {
            return Compute(defPolyn, seed, buf);
        }

        public static UInt32 Compute(UInt32 polyn, UInt32 seed, byte[] buf)
        {
            return ~CalculateHash(InitializeTable(polyn), seed, buf, 0, buf.Length);
        }

        static UInt32[] InitializeTable(UInt32 polyn)
        {
            if (polyn == defPolyn && defaultTable != null)
                return defaultTable;

            var crTbl = new UInt32[256];
            for (var i = 0; i < 256; i++)
            {
                var ent = (UInt32)i;
                for (var j = 0; j < 8; j++)
                    if ((ent & 1) == 1)
                        ent = (ent >> 1) ^ polyn;
                    else
                        ent = ent >> 1;
                crTbl[i] = ent;
            }

            if (polyn == defPolyn)
                defaultTable = crTbl;

            return crTbl;
        }

        static UInt32 CalculateHash(UInt32[] tbl, UInt32 seed, IList<byte> buf, int start, int size)
        {
            var hash = seed;
            for (var i = start; i < start + size; i++)
                hash = (hash >> 8) ^ tbl[buf[i] ^ hash & 0xff];
            return hash;
        }
    }
}
