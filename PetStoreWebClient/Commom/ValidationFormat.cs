using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PetStoreWebClient.Commom
{
    public class ValidationFormat
    {
        /// <summary>
        /// Check email user input is correct email format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool isEmailFormat(string email)
        {
            //Initialize Regex Object
            string regex = "/[A-Z0-9._%+-]+@[A-Z0-9-]+.+.[A-Z]{2,4}/igm";
            bool isMatch = Regex.IsMatch(email, regex);
            return isMatch;
        }

        /// <summary>
        /// Check phone user input is correct phone format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool isPhoneFormat(string email)
        {
            //Initialize Regex Object
            string regex = "";
            bool isMatch = Regex.IsMatch(email, regex);
            return isMatch;
        }

        /// <summary>
        /// Check password user input is correct password format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool isPasswordFormat(string email)
        {
            //Initialize Regex Object
            string regex = "^{4, 20}$";
            bool isMatch = Regex.IsMatch(email, regex);
            return isMatch;
        }
    }
}