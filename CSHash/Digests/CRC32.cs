using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSHash.Digests
{
    public class CRC32
    {
        public CRC32()
        {

        }

        /// <summary>
        /// Generates an hash from an byte array.
        /// </summary>
        /// <param name="bArr">The byte array to hash.</param>
        /// <returns>Raw byte array (the hash that can be converted into an string).</returns>
        public byte[] HashFromByteArray(byte[] bArr)
        {
            using (CSHash.Implementations.CRC32 crc = new CSHash.Implementations.CRC32())
            {
                byte[] rawHash = crc.ComputeHash(bArr);
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromByteArray(byte[] bArr)
        {
            using (CSHash.Implementations.CRC32 crc = new CSHash.Implementations.CRC32())
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                {
                    byte[] rawHash = crc.ComputeHash(bArr);
                    bReturnHash = rawHash;
                });
                return bReturnHash;
            }
        }

        public byte[] HashFromString(string value)
        {
            using (CSHash.Implementations.CRC32 crc = new CSHash.Implementations.CRC32())
            {
                byte[] rawHash = crc.ComputeHash(Encoding.Default.GetBytes(value));
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromString(string value)
        {
            using (CSHash.Implementations.CRC32 crc = new CSHash.Implementations.CRC32())
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                    {
                        byte[] rawHash = crc.ComputeHash(Encoding.Default.GetBytes(value));
                        bReturnHash = rawHash;
                    });
                return bReturnHash;
            }
        }

        public byte[] HashFromFile(string filePath, int bufferSize = 12000000)
        {
            using (CSHash.Implementations.CRC32 crc = new CSHash.Implementations.CRC32())
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    byte[] rawHash = crc.ComputeHash(bufferedStream);
                    bReturnHash = rawHash;
                }
                return bReturnHash;
            }
        }

        public async Task<byte[]> AsyncHashFromFile(string filePath, int bufferSize = 12000000)
        {
            using (CSHash.Implementations.CRC32 crc = new CSHash.Implementations.CRC32())
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    await Task.Run(() =>
                        {
                            byte[] rawHash = crc.ComputeHash(bufferedStream);
                            bReturnHash = rawHash;
                        });
                }
                return bReturnHash;
            }
        }
    }
}
