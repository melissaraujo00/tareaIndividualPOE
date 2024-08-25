using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteLibrary
{
    public class RestauranteReservaciones : IRestauranteReservaciones
    {
        public int Cantidad { get; set; }   
        public TimeSpan HoraReservacion { get; set; }
        public DateTime FechaReservacion { get; set; }
        public string SeleccionarTipo { get; set; }

        public RestauranteReservaciones(
            int cantidad,
            TimeSpan horaReservacion,
            DateTime fechaReservacion,
            string seleccionarTipo
            )
        {
            Cantidad = cantidad;
            HoraReservacion = horaReservacion;
            FechaReservacion = fechaReservacion;
            SeleccionarTipo = seleccionarTipo;
        }

        public (int, TimeSpan, DateTime, string) GetReservacion()
        {
            return (Cantidad, HoraReservacion, FechaReservacion, SeleccionarTipo);
        }

    }
}
