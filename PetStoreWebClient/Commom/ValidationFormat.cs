using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
        public static bool isEmailValid(string email)
        {
            try
            {
                MailAddress mad = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Check phone user input is correct phone format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool isPhoneFormat(string phone)
        {
            //Initialize Regex Object
            string regex = "^.{10}$";
            bool isMatch = Regex.IsMatch(phone, regex);
            return isMatch;
        }

        /// <summary>
        /// Check password user input is correct password format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool isPasswordFormat(string password)
        {
            //Initialize Regex Object
            string regex = "^.{4,20}$";
            bool isMatch = Regex.IsMatch(password, regex);
            return isMatch;
        }
    }
}