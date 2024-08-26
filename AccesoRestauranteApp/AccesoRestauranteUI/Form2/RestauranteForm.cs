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
using AccesoRestauranteUI.Form3;
using DatosPersonalesLibrary;
using RestauranteLibrary;
using static System.Resources.ResXFileRef;

namespace AccesoRestauranteUI.Form2
{
    public partial class RestauranteForm : Form
    {
        private EnvioConfirmacionReservacion _envioConfimacion;
        private Cliente _cliente;
        public RestauranteForm(
            Cliente cliente)
        {
            InitializeComponent();
            _envioConfimacion = new EnvioConfirmacionReservacion();
            _envioConfimacion.EnvioConfirmacion += OnEnvioConfirmacion;

            _cliente = cliente;


        }

        public void OnEnvioConfirmacion(object sender, string mensajeConfirmacion)
        {
            MessageBox.Show($"Su reservacion para el dia {mensajeConfirmacion} Esta confirmada",
                "Confirmacion de Reservacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void reservarButtton_Click(object sender, EventArgs e)
        {

            bool isValid = ValidateChildren();

            if (tipoComboBox.SelectedIndex == -1)
            {
                isValid = false;
                provedorError.SetError(tipoComboBox, "Debe seleccionar un tipo.");
                tipoErrorLabel.Text = "Debe seleccionar un tipo.";
            }
            else
            {
                provedorError.SetError(tipoComboBox, "");
                tipoErrorLabel.Text = string.Empty;
            }

            if (isValid)
            {
                try
                {
                    int cantidad = (int)cantidadNumericaUpDown.Value;
                    TimeSpan horaReservacion = HoraDateTimePicker.Value.TimeOfDay;
                    DateTime fechaReservacion = diaDateTimePicker.Value;
                    string seleccionarTipo = tipoComboBox.Text;

                    RestauranteReservaciones reservacion = new RestauranteReservaciones(cantidad, horaReservacion, fechaReservacion, seleccionarTipo);

                    FacturaForm formularioFacturaCita = new FacturaForm(_cliente, reservacion);
                    _envioConfimacion.SendEnvioConfirmacion(diaDateTimePicker.Text);
                    this.Hide();
                    formularioFacturaCita.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, corrija los errores en el formulario antes de enviarlo.", "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cantidadNumericaUpDown_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown numericaUpDown = sender as NumericUpDown;

            if (numericaUpDown == null)
            {
                e.Cancel = true;
                provedorError.SetError(numericaUpDown, "El valor no debe estar vacio");
                cantidadErrorLabel.Text = "El valor no debe estar vacio.";
                numericaUpDown.Focus();
            }
            else if (numericaUpDown.Value < 1 || numericaUpDown.Value > 8)
            {
                e.Cancel = true;
                provedorError.SetError(numericaUpDown, "El valor debe estar entre 1 y 8.");
                cantidadErrorLabel.Text = "El valor debe estar entre 1 y 8.";
                numericaUpDown.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(numericaUpDown, string.Empty);
                cantidadErrorLabel.Text = string.Empty;
            }
        }

        private void HoraDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTimePicker horaPicker = sender as DateTimePicker;

            TimeSpan horaMinima = new TimeSpan(8, 0, 0);
            TimeSpan horaMaxima = new TimeSpan(20, 0, 0);
            TimeSpan horaSeleccionada = horaPicker.Value.TimeOfDay;

            if (horaPicker == null)
            {

                e.Cancel = true;
                provedorError.SetError(horaPicker, "El valor no debe estar vacio");
                horalErrorLabel.Text = "El valor no debe estar vacio.";
                horaPicker.Focus();
            }
            else if (horaSeleccionada < horaMinima || horaSeleccionada > horaMaxima)
            {
                e.Cancel = true;
                provedorError.SetError(horaPicker, "La hora seleccionada debe estar entre las 08:00 AM y las 06:00 PM.");
                horalErrorLabel.Text = "La hora seleccionada debe estar entre las 08:00 AM y las 06:00 PM.";
                horaPicker.Focus();

            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(horaPicker, string.Empty);
                horalErrorLabel.Text = string.Empty;
            }
        }

        private void diaDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTimePicker diaPicker = sender as DateTimePicker;

            DateTime fechaSeleccionada = diaPicker.Value;
            DateTime hoy = DateTime.Today;
            DayOfWeek diaSemana = fechaSeleccionada.DayOfWeek;

            if (diaPicker == null)
            {
                e.Cancel = true;
                provedorError.SetError(diaPicker, "El valor no debe estar vacio");
                diaErrorLabel.Text = "El valor no debe estar vacio.";
                diaPicker.Focus();
            }
            else if (fechaSeleccionada <= hoy)
            {
                e.Cancel = true;
                provedorError.SetError(diaPicker, "La fecha debe ser posterior a hoy.");
                diaErrorLabel.Text = "La fecha debe ser posterior a hoy.";
                diaPicker.Focus();
                return;
            }
            else if (diaSemana == DayOfWeek.Sunday)
            {
                e.Cancel = true;
                provedorError.SetError(diaPicker, "El día debe ser de lunes a sábado.");
                diaErrorLabel.Text = "El día debe ser de lunes a sábado.";
                diaPicker.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(diaPicker, "");
                diaErrorLabel.Text = string.Empty;
            }
        }

        private void RestauranteForm_Load(object sender, EventArgs e)
        {
            tipoComboBox.Items.AddRange([
                "Normal",
                "Intermedia",
                "Premium"
                ]);
        }
    }
}
