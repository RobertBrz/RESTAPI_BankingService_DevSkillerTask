using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InternetBankingRESTfulService.Api
{
    public class InternetBankingApi : IInternetBankingApi
    {
        public InternetBankingApi()
        {

        }

        public string CalculateMD5(string value)
        {
            string replacedstar = Regex.Replace(value, "[0-9]", "X");

            using (MD5 md5 = MD5.Create())
            {
                byte[] input = Encoding.ASCII.GetBytes(replacedstar);
                byte[] hash = md5.ComputeHash(input);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public string GetApiVersion()
        {
            return DateTime.Now.ToUniversalTime().ToString("yyyy.MM.dd.1.0");
        }

        public bool IsPasswordStrong(string password)
        {
            if (password.Count() >= 12 &&
                password.Any(Char.IsUpper) &&
                password.Any(Char.IsLower) &&
                password.Any(Char.IsDigit) &&
               password.Any(c => c.Equals('*') &&
                !password.Any(Char.IsWhiteSpace)))
            {
                return true;
            }

            return false;
        }
    }
}
