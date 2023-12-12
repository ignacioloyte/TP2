using System;
using System.Collections.Generic;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace CapaEntidad
{
    public class Idiomas
    {
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public string Pais { get; set; }
        public string AbreviacionPais { get; set; }

        public String NombrePais
        {
            get
            {
                return Nombre + "(" + Pais + ")";

            }
        }
        public string CultureInfo
        {
            get
            {
                return Abreviacion + "-" + AbreviacionPais;
            }
        }

        public static List<Idiomas> ObtenerIdiomas()
        {
            return new List<Idiomas>
            {
                new Idiomas
                {
                    Nombre = "Español",
                    Abreviacion = "es",
                    Pais = "Argentina",
                    AbreviacionPais = "AR"
                },
                new Idiomas
                {
                    Nombre = "English",
                    Abreviacion = "en",
                    Pais = "Estados Unidos",
                    AbreviacionPais = "US"
                }
                ,
                new Idiomas
                {
                    Nombre = "Português",
                    Abreviacion = "pt",
                    Pais = "Brazil",
                    AbreviacionPais = "BR"
                }
            };
        }

        
    }
}
