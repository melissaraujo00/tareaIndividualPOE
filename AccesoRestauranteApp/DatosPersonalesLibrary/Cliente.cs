using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesLibrary
{
    public class Cliente : ICliente
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public string Correo { get; set; }
        
        public Cliente(
            string nombre, 
            int numero,
            string correo
            )
        {
            Nombre = nombre;
            Numero = numero;
            Correo = correo;
        }

        public string GetCliente()
        {
            return $" {Nombre} {Numero} {Correo}";
        }
    }
}
