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
using static System.Net.Mime.MediaTypeNames;

namespace AccesoRestauranteUI.Form3
{
    public partial class FacturaForm : Form
    {
        private ImpresionFactura _enviarImprimir;
        public FacturaForm(
            string nombre,
            string numero,
            string correo,
            decimal cantidad,
            DateTime horaReservacion,
            DateTime fechaReservacion,
            string seleccionarTipo
            )
        {
            InitializeComponent();
            _enviarImprimir = new ImpresionFactura();
            _enviarImprimir.EnviarImprimir += OnEnvioImprimir;

            nombreRespuestaLabel.Text = nombre;
            numeroRespuestaLabel.Text = numero;
            correoRespuestaLabel.Text = correo;
            cantidadRespuestaLabel.Text = cantidad.ToString();
            horaRespuestaLabel.Text = horaReservacion.ToString(@"hh\:mm");
            fechaRespuestaLabel.Text = fechaReservacion.ToShortDateString();
            tipoRespuestaLabel.Text = seleccionarTipo;

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
                _enviarImprimir.SendEnvioImprimir(nombreRespuestaLabel.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
