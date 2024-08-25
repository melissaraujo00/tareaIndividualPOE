using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesLibrary
{
    public class DatosPersonales : IDatosPersonales
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public string Correo { get; set; }
        
        public DatosPersonales(
            string nombre, 
            int numero,
            string correo
            )
        {
            Nombre = nombre;
            Numero = numero;
            Correo = correo;
        }

        public (string, int, string) GetDatosPersonales()
        {
            return (Nombre, Numero, Correo);
        }
    }
}
