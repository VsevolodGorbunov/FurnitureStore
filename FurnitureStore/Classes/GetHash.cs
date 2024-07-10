using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Classes
{
    public class GetHash
    {
        public static string Get_Hash(string password) // шифрование пароля
        {
            using (var hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.
                      GetBytes(password)).
                             Select(x => x.ToString("X2")));
            }
        }
    }
}
