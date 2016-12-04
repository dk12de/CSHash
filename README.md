# CSHash
**CSHash** is an open source hashing library made in C#, for making hashing easier. It supports MD5, SHA-1 to SHA-512, RIPEMD-160, CRC-32, and more soon.

# Using CSHash
Using CSHash is very easy, add an ```using``` directive, create an constructor for an digest class (like that: ```MD5 md5 = new MD5();```) and you are ready to go! CSHash also supports awaitable operations for hashing, so GUI threads won't hang up.

# Code example for an C# WinForms application (async)
```c#
using CSHash.Digests;
using CSHash.Tools;

        private async void Form1_Load(object sender, EventArgs e)
        {
            string stringToHash = "Hello, World!";
            string hashOfString = await ComputeHashFromString(stringToHash); // returns 0a0a9f2a6772942557ab5355d76af442f8f65e01
            MessageBox.Show(hashOfString);
        }

        public async Task<string> ComputeHashFromString(string value)
        {
            SHA1 sha1 = new SHA1(); Converter converter = new Converter(); 

            byte[] hash = await sha1.AsyncHashFromString(value);

            string fullHash = converter.ConvertByteArrayToFullString(hash);

            return fullHash;
        }

```
