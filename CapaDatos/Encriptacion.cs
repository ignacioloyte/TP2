using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaDatos
{
   public class Encriptado
    {
       
        
            //MEtodo Encriptacion
            public string Encrypt(string mensaje)
            {
                string perro = "coding con c";
                byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);

                MD5 md5 = MD5.Create();
                TripleDES tripldes = TripleDES.Create();

                tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(perro));
                tripldes.Mode = CipherMode.CBC;

                ICryptoTransform transform = tripldes.CreateEncryptor();
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

                return Convert.ToBase64String(result);
            }

            //Medoto desencriptacion

            public string Decrypt(string mensajeEn)
            {
                string perro = "coding con c";
                byte[] data = Convert.FromBase64String(mensajeEn);

                MD5 md5 = MD5.Create();
                TripleDES tripldes = TripleDES.Create();

                tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(perro));
                tripldes.Mode = CipherMode.CBC;

                ICryptoTransform transform = tripldes.CreateDecryptor();
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

                return UTF8Encoding.UTF8.GetString(result);

            }
        }
    
    
}
