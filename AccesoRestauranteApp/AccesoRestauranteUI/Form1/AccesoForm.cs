using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoRestauranteUI.EventosPersonalizado;
using AccesoRestauranteUI.Form2;
using AccesoRestauranteUI.Form3;
using DatosPersonalesLibrary;

namespace AccesoRestauranteUI.Form1
{
    public partial class AccesoForm : Form
    {
        private EnvioExitosoFormulario _envioExitoso;

        public AccesoForm()
        {
            InitializeComponent();
            _envioExitoso = new EnvioExitosoFormulario();
            _envioExitoso.EnvioExitoso += OnEnvioExitoso;
        }

        public void OnEnvioExitoso(object sender, string mensajeExito)
        {
            MessageBox.Show($"Estimado usuario {mensajeExito} su formulario ha sido enviado con exito!!",
                "Envio Exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void enviarButton_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateChildren();

            if (isValid)
            {
                try
                {
                    string nombre = nombreTextBox.Text; 
                    int numero = Convert.ToInt32(numeroTextBox.Text);  
                    string correo = correoTextBox.Text;

                    Cliente cliente = new Cliente(nombre, numero, correo);

                    RestauranteForm formularioFactura = new RestauranteForm(cliente);

                    _envioExitoso.SendEnvioExitoso(nombreTextBox.Text);
                    this.Hide();

                    formularioFactura.ShowDialog();
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
        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                e.Cancel = true;
                provedorError.SetError(nombreTextBox, "El nombre no debe estar vacio");
                nombreErrorLabel.Text = "El nombre no debe de estar vacio";
                nombreTextBox.Focus();
            }
            else if (double.TryParse(nombreTextBox.Text, out _))
            {
                e.Cancel = true;
                provedorError.SetError(nombreTextBox, "El nombre no debe ser un numero");
                nombreErrorLabel.Text = "El nombre no debe ser un numero";
                nombreTextBox.Focus();
            }
            else if (Regex.IsMatch(nombreTextBox.Text, @"[^a-zA-Z0-9\s]"))
            {
                e.Cancel = true;
                provedorError.SetError(nombreTextBox, "El nombre no debe contener caracteres especiales.");
                nombreErrorLabel.Text = "El nombre no debe contener caracteres especiales.";
                nombreTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(nombreTextBox, "");
                nombreErrorLabel.Text = string.Empty;
            }
        }

        private void numeroTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(numeroTextBox.Text))
            {
                e.Cancel = true;
                provedorError.SetError(numeroTextBox, "El numero no debe de estar vacio");
                numeroErrorLabel.Text = "El numero no debe de estar vacio";
                numeroTextBox.Focus();
            }
            else if (!int.TryParse(numeroTextBox.Text, out int numero))
            {
                e.Cancel = true;
                provedorError.SetError(numeroTextBox, "Debe colocar solo numeros y numeros enteros");
                numeroErrorLabel.Text = "Debe colocar solo numeros y numeros enteros";
                numeroTextBox.Focus();
            }
            else if (numero < 0)
            {
                e.Cancel = true;
                provedorError.SetError(numeroTextBox, "El numero debe ser mayor a 0");
                numeroErrorLabel.Text = "El numero debe ser mayor a 0";
                numeroTextBox.Focus();
            }
            else if (!Regex.IsMatch(numeroTextBox.Text, @"^\d{8}$"))
            {
                e.Cancel = true;
                provedorError.SetError(numeroTextBox, "El número debe tener exactamente 8 dígitos.");
                numeroErrorLabel.Text = "El número debe tener exactamente 8 dígitos.";
                numeroTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(numeroTextBox, "");
                numeroErrorLabel.Text = string.Empty;

            }
        }

        private void correoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(correoTextBox.Text))
            {
                e.Cancel = true;
                provedorError.SetError(correoTextBox, "El correo no debe de estar vacio");
                correoErrorLabel.Text = "El correo no debe de estar vacio";
                correoTextBox.Focus();
            }
            else if (double.TryParse(correoTextBox.Text, out _))
            {
                e.Cancel = true;
                provedorError.SetError(correoTextBox, "El correo debe ser un texto no un numero");
                correoErrorLabel.Text = "El correo debe ser un texto no un numero";
                correoTextBox.Focus();
            }
            else if (!correoTextBox.Text.Contains("@"))
            {
                e.Cancel = true;
                provedorError.SetError(correoTextBox, "El correo debe contener el carácter '@'.");
                correoErrorLabel.Text = "El correo debe contener el carácter '@'.";
                correoTextBox.Focus();
            }
            else if (correoTextBox.Text.Contains(" "))
            {
                e.Cancel = true;
                provedorError.SetError(correoTextBox, "El correo no debe contener espacios.");
                correoErrorLabel.Text = "El correo no debe contener espacios.";
                correoTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(correoTextBox, "");
                correoErrorLabel.Text = string.Empty;
            }
        }
        private void comentarioTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (comentarioTextBox.Text.Length > 200)
            {
                e.Cancel = true;
                provedorError.SetError(comentarioTextBox, "El comentario no puede exceder los 200 caracteres.");
                comentarioErrorLabel.Text = "El comentario no puede exceder los 200 caracteres.";
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(comentarioTextBox, "");
                comentarioErrorLabel.Text = string.Empty;
            }
        }


        private void AccesoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
