using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHash.Tools
{
    public class Comparer
    {
        public Comparer()
        {

        }

        public bool CompareTwoByteArrays(byte[] bArr1, byte[] bArr2)
        {
            if (bArr1.SequenceEqual(bArr2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
