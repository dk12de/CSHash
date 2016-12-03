﻿using System;
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

        /// <summary>
        /// Compares two byte arrays, if they are equal, it returns 'true', otherwise it returns 'false'
        /// </summary>
        /// <param name="bArr1">The first byte array to compare</param>
        /// <param name="bArr2">The second byte array to compare</param>
        /// <returns>'true' if equal, 'false' if not</returns>
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
