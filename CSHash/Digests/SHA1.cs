﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CSHash.Digests
{
    public class SHA1
    {
        public SHA1()
        {

        }

        public byte[] HashFromByteArray(byte[] bArr)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] rawHash = sha1.ComputeHash(bArr);
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromByteArray(byte[] bArr)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                {
                    byte[] rawHash = sha1.ComputeHash(bArr);
                    bReturnHash = rawHash;
                });
                return bReturnHash;
            }
        }

        public byte[] HashFromString(string value)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] rawHash = sha1.ComputeHash(Encoding.Default.GetBytes(value));
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromString(string value)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                    {
                        byte[] rawHash = sha1.ComputeHash(Encoding.Default.GetBytes(value));
                        bReturnHash = rawHash;
                    });
                return bReturnHash;
            }
        }

        public byte[] HashFromFile(string filePath, int bufferSize = 12000000)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    byte[] rawHash = sha1.ComputeHash(bufferedStream);
                    bReturnHash = rawHash;
                }
                return bReturnHash;
            }
        }

        public async Task<byte[]> AsyncHashFromFile(string filePath, int bufferSize = 12000000)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    await Task.Run(() =>
                        {
                            byte[] rawHash = sha1.ComputeHash(bufferedStream);
                            bReturnHash = rawHash;
                        });
                }
                return bReturnHash;
            }
        }
    }
}
