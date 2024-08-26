using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoRestauranteUI.EventosPersonalizado
{
    public class ImpresionFactura
    {
        public event EventHandler<string> EnviarImprimir;

        protected virtual void OnEnvioImprimir(string mensajeImpresion)
        {
            EnviarImprimir?.Invoke(this, mensajeImpresion);
        }

        public void SendEnvioImprimir(string mensajeImpresion)
        {
            OnEnvioImprimir(mensajeImpresion);
        }
    }
}
