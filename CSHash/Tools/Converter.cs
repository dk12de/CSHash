using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHash.Tools
{
    public class Converter
    {
        public Converter()
        {

        }

        public string ConvertRawByteArrayToFullString(byte[] bArr)
        {
            return BitConverter.ToString(bArr).Replace("-", String.Empty).ToLower();
        }

        public string ConvertRawByteArrayToString(byte[] bArr)
        {
            return BitConverter.ToString(bArr);
        }
    }
}
