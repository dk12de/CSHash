using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CSHash
{
    public class MD5
    {
        public MD5()
        {

        }

        public byte[] HashFromByteArray(byte[] bArr)
        {
            using (MD5Cng md5 = new MD5Cng())
            {
                byte[] rawHash = md5.ComputeHash(bArr);
                return rawHash;
            }
        }

        public async Task<byte[]> HashFromByteArray(byte[] bArr)
        {
            using (MD5Cng md5 = new MD5Cng())
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                {
                    byte[] rawHash = md5.ComputeHash(bArr);
                    bReturnHash = rawHash;
                });
                return bReturnHash;
            }
        }

        public byte[] HashFromString(string value)
        {
            using (MD5Cng md5 = new MD5Cng())
            {
                byte[] rawHash = md5.ComputeHash(Encoding.Default.GetBytes(value));
                return rawHash;
            }
        }

        public async Task<byte[]> HashFromString(string value)
        {
            using (MD5Cng md5 = new MD5Cng())
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                    {
                        byte[] rawHash = md5.ComputeHash(Encoding.Default.GetBytes(value));
                        bReturnHash = rawHash;
                    });
                return bReturnHash;
            }
        }
    }
}
