using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreWebClient.Commom
{
    public class Encryptor
    {
        public static string SHA256_Encrypt(string userInput)
        {
            //create a SHA256 encrypt
            using (SHA256 sha256 = SHA256Managed.Create())
            {
                //ComputeHash - returns byte array
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(userInput));

                //Convert byte array to a String
                StringBuilder hashString = new StringBuilder();
                foreach (byte i in hashBytes)
                {
                    hashString.Append(i.ToString("x2"));
                }
                return hashString.ToString();
            }
        }
    }
}