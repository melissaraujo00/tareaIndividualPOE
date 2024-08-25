namespace AccesoRestauranteUI.Form1
{
    partial class AccesoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tituloLabel = new Label();
            nombreLabel = new Label();
            numeroLabel = new Label();
            nombreTextBox = new TextBox();
            numeroTextBox = new TextBox();
            correoLabel = new Label();
            correoTextBox = new TextBox();
            comentarioLabel = new Label();
            comentarioTextBox = new TextBox();
            enviarButton = new Button();
            provedorError = new ErrorProvider(components);
            nombreErrorLabel = new Label();
            numeroErrorLabel = new Label();
            correoErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)provedorError).BeginInit();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(157, 38);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(451, 60);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "¡Datos para Reserva!";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(124, 151);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(122, 32);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre: ";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numeroLabel.Location = new Point(124, 231);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new Size(122, 32);
            numeroLabel.TabIndex = 2;
            numeroLabel.Text = "Número: ";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(253, 152);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(373, 31);
            nombreTextBox.TabIndex = 3;
            nombreTextBox.Validating += nombreTextBox_Validating;
            // 
            // numeroTextBox
            // 
            numeroTextBox.Location = new Point(253, 234);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(373, 31);
            numeroTextBox.TabIndex = 4;
            numeroTextBox.Validating += numeroTextBox_Validating;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            correoLabel.Location = new Point(12, 298);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new Size(234, 32);
            correoLabel.TabIndex = 5;
            correoLabel.Text = "Correo Electronico:";
            // 
            // correoTextBox
            // 
            correoTextBox.Location = new Point(252, 303);
            correoTextBox.Name = "correoTextBox";
            correoTextBox.Size = new Size(374, 31);
            correoTextBox.TabIndex = 6;
            correoTextBox.Validating += correoTextBox_Validating;
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comentarioLabel.Location = new Point(84, 373);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new Size(162, 32);
            comentarioLabel.TabIndex = 7;
            comentarioLabel.Text = "Comentario: ";
            // 
            // comentarioTextBox
            // 
            comentarioTextBox.Location = new Point(256, 376);
            comentarioTextBox.Multiline = true;
            comentarioTextBox.Name = "comentarioTextBox";
            comentarioTextBox.Size = new Size(370, 175);
            comentarioTextBox.TabIndex = 8;
            // 
            // enviarButton
            // 
            enviarButton.Location = new Point(276, 592);
            enviarButton.Name = "enviarButton";
            enviarButton.Size = new Size(156, 56);
            enviarButton.TabIndex = 9;
            enviarButton.Text = "Enviar";
            enviarButton.UseVisualStyleBackColor = true;
            enviarButton.Click += enviarButton_Click;
            // 
            // provedorError
            // 
            provedorError.ContainerControl = this;
            // 
            // nombreErrorLabel
            // 
            nombreErrorLabel.AutoSize = true;
            nombreErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nombreErrorLabel.ForeColor = Color.Red;
            nombreErrorLabel.Location = new Point(256, 194);
            nombreErrorLabel.Name = "nombreErrorLabel";
            nombreErrorLabel.Size = new Size(0, 25);
            nombreErrorLabel.TabIndex = 10;
            // 
            // numeroErrorLabel
            // 
            numeroErrorLabel.AutoSize = true;
            numeroErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            numeroErrorLabel.ForeColor = Color.Red;
            numeroErrorLabel.Location = new Point(253, 275);
            numeroErrorLabel.Name = "numeroErrorLabel";
            numeroErrorLabel.Size = new Size(0, 25);
            numeroErrorLabel.TabIndex = 11;
            // 
            // correoErrorLabel
            // 
            correoErrorLabel.AutoSize = true;
            correoErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            correoErrorLabel.ForeColor = Color.Red;
            correoErrorLabel.Location = new Point(254, 342);
            correoErrorLabel.Name = "correoErrorLabel";
            correoErrorLabel.Size = new Size(0, 25);
            correoErrorLabel.TabIndex = 12;
            // 
            // AccesoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 697);
            Controls.Add(correoErrorLabel);
            Controls.Add(numeroErrorLabel);
            Controls.Add(nombreErrorLabel);
            Controls.Add(enviarButton);
            Controls.Add(comentarioTextBox);
            Controls.Add(comentarioLabel);
            Controls.Add(correoTextBox);
            Controls.Add(correoLabel);
            Controls.Add(numeroTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(numeroLabel);
            Controls.Add(nombreLabel);
            Controls.Add(tituloLabel);
            Name = "AccesoForm";
            Text = "AccesoForm";
            ((System.ComponentModel.ISupportInitialize)provedorError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label nombreLabel;
        private Label numeroLabel;
        private TextBox nombreTextBox;
        private TextBox numeroTextBox;
        private Label correoLabel;
        private TextBox correoTextBox;
        private Label comentarioLabel;
        private TextBox comentarioTextBox;
        private Button enviarButton;
        private ErrorProvider provedorError;
        private Label correoErrorLabel;
        private Label numeroErrorLabel;
        private Label nombreErrorLabel;
    }
}