using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControlEnvejecimiento.Services
{
    public class Hash
    {
        internal static String getSHA(String message)
        {
            if(message == null || message == String.Empty)
            {
                throw new ArgumentException("La cadena esta vacia o es nula", nameof(message));
            }
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));
                String result = String.Empty;
                foreach (byte b in hash)
                {
                    result += $"{b:X2}";
                }
                return result;
            }

        }
    }
}
