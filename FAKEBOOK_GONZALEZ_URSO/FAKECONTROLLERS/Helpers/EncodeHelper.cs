using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace FAKECONTROLLERS.Helpers
{
    public class EncodeHelper
    {
        public string Encode(string value)
        {
            StringBuilder sb = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
            byte[] hash = md5.ComputeHash(inputBytes);

            foreach (Byte item in hash)
            {
                sb.Append(item.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
