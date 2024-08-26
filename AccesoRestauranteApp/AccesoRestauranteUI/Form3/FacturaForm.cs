using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoRestauranteUI.EventosPersonalizado;
using DatosPersonalesLibrary;
using RestauranteLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace AccesoRestauranteUI.Form3
{
    public partial class FacturaForm : Form
    {
        private ImpresionFactura _enviarImprimir;
        private Cliente _cliente;
        private RestauranteReservaciones _reservacion;

        public FacturaForm(
            Cliente cliente, RestauranteReservaciones reservacion
            )
        {
            InitializeComponent();
            _enviarImprimir = new ImpresionFactura();
            _enviarImprimir.EnviarImprimir += OnEnvioImprimir;

            _cliente = cliente;
            _reservacion = reservacion;

            nombreRespuestaLabel.Text = _cliente.Nombre;
            numeroRespuestaLabel.Text = _cliente.Numero.ToString();
            correoRespuestaLabel.Text = _cliente.Correo;

            cantidadRespuestaLabel.Text = _reservacion.Cantidad.ToString();
            horaRespuestaLabel.Text = _reservacion.HoraReservacion.ToString(@"hh\:mm");
            fechaRespuestaLabel.Text = _reservacion.FechaReservacion.ToShortDateString();
            tipoRespuestaLabel.Text = _reservacion.SeleccionarTipo;

        }

        public void OnEnvioImprimir(object sender, string mensajeImpresion)
        {
            MessageBox.Show($"Su Factura {mensajeImpresion} Esta impresa",
              "Factura Impresa",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            try
            {
                _enviarImprimir.SendEnvioImprimir(_cliente.Nombre);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
