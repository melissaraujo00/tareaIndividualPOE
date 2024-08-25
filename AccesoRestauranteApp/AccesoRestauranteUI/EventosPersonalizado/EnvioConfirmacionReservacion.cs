using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoRestauranteUI.EventosPersonalizado
{
    public class EnvioConfirmacionReservacion
    {
        public event EventHandler<string> EnvioConfirmacion;
        
        protected virtual void OnEnvioConfirmacion(string mensajeConfirmacion)
        {
            EnvioConfirmacion?.Invoke(this, mensajeConfirmacion);
        }

        public void SendEnvioConfirmacion(string mensajeConfirmacion)
        {
            OnEnvioConfirmacion(mensajeConfirmacion);
        }
    }
}
