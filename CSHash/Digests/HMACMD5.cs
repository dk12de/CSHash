using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CSHash.Digests
{
    public class HMACMD5
    {
        public HMACMD5()
        {

        }

        public byte[] HashFromByteArray(byte[] bArr)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5())
            {
                byte[] rawHash = md5.ComputeHash(bArr);
                return rawHash;
            }
        }

        public byte[] HashFromByteArray(byte[] bArr, byte[] hmacKey)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(hmacKey))
            {
                byte[] rawHash = md5.ComputeHash(bArr);
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromByteArray(byte[] bArr)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5())
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

        public async Task<byte[]> AsyncHashFromByteArray(byte[] bArr, byte[] hmacKey)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(hmacKey))
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
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5())
            {
                byte[] rawHash = md5.ComputeHash(Encoding.Default.GetBytes(value));
                return rawHash;
            }
        }

        public byte[] HashFromString(string value, byte[] hmacKey)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(hmacKey))
            {
                byte[] rawHash = md5.ComputeHash(Encoding.Default.GetBytes(value));
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromString(string value)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5())
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

        public async Task<byte[]> AsyncHashFromString(string value, byte[] hmacKey)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(hmacKey))
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

        public byte[] HashFromFile(string filePath, int bufferSize = 12000000)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5())
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    byte[] rawHash = md5.ComputeHash(bufferedStream);
                    bReturnHash = rawHash;
                }
                return bReturnHash;
            }
        }

        public byte[] HashFromFile(string filePath, byte[] hmacKey, int bufferSize = 12000000)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(hmacKey))
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    byte[] rawHash = md5.ComputeHash(bufferedStream);
                    bReturnHash = rawHash;
                }
                return bReturnHash;
            }
        }

        public async Task<byte[]> AsyncHashFromFile(string filePath, int bufferSize = 12000000)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5())
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    await Task.Run(() =>
                        {
                            byte[] rawHash = md5.ComputeHash(bufferedStream);
                            bReturnHash = rawHash;
                        });
                }
                return bReturnHash;
            }
        }

        public async Task<byte[]> AsyncHashFromFile(string filePath, byte[] hmacKey, int bufferSize = 12000000)
        {
            using (System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(hmacKey))
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    await Task.Run(() =>
                    {
                        byte[] rawHash = md5.ComputeHash(bufferedStream);
                        bReturnHash = rawHash;
                    });
                }
                return bReturnHash;
            }
        }
    }
}
