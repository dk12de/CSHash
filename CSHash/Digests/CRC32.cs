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

        public byte[] HashFromByteArray(byte[] bArr)
        {
            {
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromByteArray(byte[] bArr)
        {
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                {
                    bReturnHash = rawHash;
                });
                return bReturnHash;
            }
        }

        public byte[] HashFromString(string value)
        {
            {
                return rawHash;
            }
        }

        public async Task<byte[]> AsyncHashFromString(string value)
        {
            {
                byte[] bReturnHash = null;
                await Task.Run(() =>
                    {
                        bReturnHash = rawHash;
                    });
                return bReturnHash;
            }
        }

        public byte[] HashFromFile(string filePath, int bufferSize = 12000000)
        {
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    bReturnHash = rawHash;
                }
                return bReturnHash;
            }
        }

        public async Task<byte[]> AsyncHashFromFile(string filePath, int bufferSize = 12000000)
        {
            {
                byte[] bReturnHash = null;
                using (BufferedStream bufferedStream = new BufferedStream(File.OpenRead(filePath), bufferSize))
                {
                    await Task.Run(() =>
                        {
                            bReturnHash = rawHash;
                        });
                }
                return bReturnHash;
            }
        }
    }
}
