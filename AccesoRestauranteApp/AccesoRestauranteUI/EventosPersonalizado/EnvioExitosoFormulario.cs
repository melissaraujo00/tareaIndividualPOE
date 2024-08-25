using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoRestauranteUI.EventosPersonalizado
{
    public class EnvioExitosoFormulario
    {
        public event EventHandler<string> EnvioExitoso;

        protected virtual void OnEnvioExitoso(string mensajeExito)
        {
            EnvioExitoso?.Invoke(this, mensajeExito);
        }

        public void SendEnvioExitoso(string mensajeExito)
        {
            OnEnvioExitoso(mensajeExito);
        }
    }
}
