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

        public string ConvertToBase64String(byte[] bArr)
        {
            return Convert.ToBase64String(bArr);
        }
        
        public string ConvertToBase64String(string value)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(value));
        }

        public byte[] ConvertFromBase64String(string value)
        {
            return Convert.FromBase64String(value);
        }

        public string ConvertByteArrayToFullString(byte[] bArr)
        {
            return BitConverter.ToString(bArr).Replace("-", String.Empty).ToLower();
        }

        public string ConvertByteArrayToString(byte[] bArr)
        {
            return BitConverter.ToString(bArr);
        }

        public byte[] UInt32ToBigEndian(UInt32 value)
        {
            byte[] result = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) { Array.Reverse(result); }           
            return result;
        }
    }
}
