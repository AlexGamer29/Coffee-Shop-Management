using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Login
{
    internal class Hashing
    {
        public string plainText;
        public string saltBytes;

        static string GenerateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[8];
            rng.GetBytes(buff);
            string salt = Convert.ToBase64String(buff);
            return salt;
        }

        static string HashString(string plainText, string saltBytes)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(plainText);
            byte[] src = Encoding.Unicode.GetBytes(saltBytes);
            byte[] dst = new byte[src.Length + bytes.Length];
            byte[] inArray = null;
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA256");
            inArray = algorithm.ComputeHash(dst);
            string hashValue = Convert.ToBase64String(inArray);
            return hashValue;
        }
    }
}
