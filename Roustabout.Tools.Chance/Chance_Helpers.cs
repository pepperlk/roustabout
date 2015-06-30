using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {
        public string Capitalize(string word)
        {
            return word.First().ToString().ToUpper() + string.Join("", word.Skip(1));
        }

        public string Base64(string instring) {

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(instring));

        }

        public string Hash(bool upper = false, int length = 40)
        {

            var pool = upper ? HEX_POOL.ToUpper() : HEX_POOL;
            return this.String( pool: pool, length: length);
        }


        public string MD5(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public string Pad(int number, int width,string pad = "")
        {
            // Default pad to 0 if none provided
            pad = !string.IsNullOrEmpty(pad) ? pad : "0";
            // Convert number to a string
            var snumber = number + "";
            return snumber.Length >= width ? snumber :  string.Join(pad, new string[width - snumber.Length + 1])+ snumber;
        }

    }
}
