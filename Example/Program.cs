using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHash;
using CSHash.Tools;
using CSHash.Digests;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Please enter an string to hash...");
            string stringToHash = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stringToHash)) { Console.WriteLine("String cannot be empty or white space only" + Environment.NewLine); goto start; }

            MD5 md5 = new MD5();
            Converter converter = new Converter();

            byte[] hash = md5.HashFromString(stringToHash);
            string fullHash = converter.ConvertRawByteArrayToFullString(hash);

            Console.WriteLine("Full hash of string: " + fullHash);
            Console.ReadLine();
        }
    }
}
