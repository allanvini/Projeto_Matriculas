using System.Text;
using System.Security.Cryptography;

namespace Projeto_Integrador.Utils
{
    class Seguranca
    {
        public static string generateHash(string input)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, input);
                return hash;
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int index = 0; index < data.Length; index++)
            {
                sBuilder.Append(data[index].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
