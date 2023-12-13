using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaDatos
{
    public static class Encriptado
    { 
    public static string HashPassword(string password)
    {
        // Generar una sal aleatoria
        byte[] salt;
        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

        // Crear el hash de la contraseña
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
        byte[] hash = pbkdf2.GetBytes(20);

        // Combinar la sal y el hash
        byte[] hashBytes = new byte[36];
        Array.Copy(salt, 0, hashBytes, 0, 16);
        Array.Copy(hash, 0, hashBytes, 16, 20);

        // Convertir a string base64
        string hashedPassword = Convert.ToBase64String(hashBytes);

        return hashedPassword;
    }

        public static bool ValidatePassword(string enteredPassword, string storedHash)
        {

            byte[] hashBytes;
            try
            {
                hashBytes = Convert.FromBase64String(storedHash);
            }
            catch
            {
                // Manejar el caso donde storedHash no está en formato Base64 válido
                return false;
            }

            // Verificar si el tamaño del hash es el esperado
            if (hashBytes.Length != 36)
            {
                // El hash no tiene el formato o tamaño esperado
                return false;
            }
   // El bloque anterior fue generado para que si ingresan una contraseña manualmente por BD no arroje una excepción sin ser manejada

            // Extraer la sal del hash
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Computar el hash en la contraseña ingresada
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Comparar los resultados
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
