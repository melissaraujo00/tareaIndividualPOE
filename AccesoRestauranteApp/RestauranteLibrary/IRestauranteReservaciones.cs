using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLibrary
{
    internal interface IRestauranteReservaciones
    {
        (int, TimeSpan, DateTime, string) GetReservacion();
    }
}
