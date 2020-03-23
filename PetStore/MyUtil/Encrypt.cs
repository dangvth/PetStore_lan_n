using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PetStore.MyUtil
{
    class Encrypt
    {
        /// <summary>
        /// Encrypt string user input by SHA256 encrypt
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string SHA256_Encrypt(string password)
        {
            //create a SHA256 Encrypt
            using (SHA256 sha256 = SHA256Managed.Create())
            {
                //computeHash - return Byte array
                byte[] hashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                //Convert byte array to a string
                StringBuilder hashString = new StringBuilder();
                foreach (byte i in hashByte)
                {
                    hashString.Append(i.ToString("x2"));
                }
                return hashString.ToString();
            }
        }
    }
}
