using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace projeto2023.controllers
{
    public class Security
    {
        public static string Hash_login(string text)
        {
            SHA256 prote = SHA256.Create();
            byte[] bytes = prote.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}
