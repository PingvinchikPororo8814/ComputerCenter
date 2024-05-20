using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenter.Forms.Utils
{
    internal class UtilMaster
    {
        public static void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSuccess(string error)
        {
            MessageBox.Show(error, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string EncryptPass(string pass)
        {
            MD5 md5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(pass);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder sb = new();
            foreach (var a in hash)
            {
                sb.Append(a.ToString("X2"));
            }

            return Convert.ToString(sb);
        }
    }
}
