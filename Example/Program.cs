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
            Console.WriteLine("CSHash example application" + Environment.NewLine);

            start:
            Console.WriteLine("Enter an hash algorithm name (MD5, SHA-1, ...): ");

            string hashAlgorithm = Console.ReadLine();

            if (String.IsNullOrEmpty(hashAlgorithm)) { goto start; }

            if (hashAlgorithm == "MD5")
            {
                Console.WriteLine(Environment.NewLine + "Enter an string: ");

                string hashingString = Console.ReadLine();

                MD5 md5 = new MD5(); Converter converter = new Converter();
                byte[] rawHash = md5.HashFromString(hashingString);
                string fullHash = converter.ConvertByteArrayToFullString(rawHash);

                Console.WriteLine(Environment.NewLine + "MD5 hash: " + fullHash); Console.ReadLine(); goto start;
            }
            else if (hashAlgorithm == "CRC-32")
            {
                Console.WriteLine(Environment.NewLine + "Enter an string: ");

                string hashingString = Console.ReadLine();

                CRC32 crc = new CRC32(); Converter converter = new Converter();
                byte[] rawHash = crc.HashFromString(hashingString);
                string fullHash = converter.ConvertByteArrayToFullString(rawHash);

                Console.WriteLine(Environment.NewLine + "CRC-32 hash: " + fullHash); Console.ReadLine(); goto start;
            }
            else if (hashAlgorithm == "SHA-1")
            {
                Console.WriteLine(Environment.NewLine + "Enter an string: ");

                string hashingString = Console.ReadLine();

                SHA1 sha1 = new SHA1(); Converter converter = new Converter();
                byte[] rawHash = sha1.HashFromString(hashingString);
                string fullHash = converter.ConvertByteArrayToFullString(rawHash);

                Console.WriteLine(Environment.NewLine + "SHA1 hash: " + fullHash); Console.ReadLine(); goto start;
            }
            else if (hashAlgorithm == "SHA-256")
            {
                Console.WriteLine(Environment.NewLine + "Enter an string: ");

                string hashingString = Console.ReadLine();

                SHA256 sha256 = new SHA256(); Converter converter = new Converter();
                byte[] rawHash = sha256.HashFromString(hashingString);
                string fullHash = converter.ConvertByteArrayToFullString(rawHash);

                Console.WriteLine(Environment.NewLine + "SHA256 hash: " + fullHash); Console.ReadLine(); goto start;
            }
            else if (hashAlgorithm == "SHA-384")
            {
                Console.WriteLine(Environment.NewLine + "Enter an string: ");

                string hashingString = Console.ReadLine();

                SHA384 sha384 = new SHA384(); Converter converter = new Converter();
                byte[] rawHash = sha384.HashFromString(hashingString);
                string fullHash = converter.ConvertByteArrayToFullString(rawHash);

                Console.WriteLine(Environment.NewLine + "SHA384 hash: " + fullHash); Console.ReadLine(); goto start;
            }
            else if (hashAlgorithm == "SHA-512")
            {
                Console.WriteLine(Environment.NewLine + "Enter an string: ");

                string hashingString = Console.ReadLine();

                SHA512 sha512 = new SHA512(); Converter converter = new Converter();
                byte[] rawHash = sha512.HashFromString(hashingString);
                string fullHash = converter.ConvertByteArrayToFullString(rawHash);

                Console.WriteLine(Environment.NewLine + "SHA512 hash: " + fullHash); Console.ReadLine(); goto start;
            }
            else if (hashAlgorithm == "Exit")
            {
            
            }
            else
            {
                goto start;
            }
        }
    }
}
