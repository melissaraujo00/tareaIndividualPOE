using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesLibrary
{
    internal interface IDatosPersonales
    {
        (string, int, string) GetDatosPersonales();
    }
}
