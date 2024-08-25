namespace AccesoRestauranteUI.Form2
{
    partial class RestauranteForm
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
            cantidadLabel = new Label();
            cantidadNumericUpDown = new NumericUpDown();
            horaLabel = new Label();
            HoraDateTimePicker = new DateTimePicker();
            diaLabel = new Label();
            diaDateTimePicker1 = new DateTimePicker();
            mesaLabel = new Label();
            tipoComboBox = new ComboBox();
            reservarButtton = new Button();
            cantidadErrorLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            diaErrorLabel = new Label();
            tipoErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cantidadNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(339, 38);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(233, 60);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "¡Reservar!";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cantidadLabel.Location = new Point(82, 153);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new Size(305, 38);
            cantidadLabel.TabIndex = 1;
            cantidadLabel.Text = "Cantidad de Personas:";
            // 
            // cantidadNumericUpDown
            // 
            cantidadNumericUpDown.Location = new Point(455, 162);
            cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            cantidadNumericUpDown.Size = new Size(180, 31);
            cantidadNumericUpDown.TabIndex = 3;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            horaLabel.Location = new Point(298, 234);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new Size(89, 38);
            horaLabel.TabIndex = 4;
            horaLabel.Text = "Hora:";
            // 
            // HoraDateTimePicker
            // 
            HoraDateTimePicker.Location = new Point(455, 241);
            HoraDateTimePicker.Name = "HoraDateTimePicker";
            HoraDateTimePicker.Size = new Size(300, 31);
            HoraDateTimePicker.TabIndex = 5;
            // 
            // diaLabel
            // 
            diaLabel.AutoSize = true;
            diaLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            diaLabel.Location = new Point(318, 332);
            diaLabel.Name = "diaLabel";
            diaLabel.Size = new Size(69, 38);
            diaLabel.TabIndex = 6;
            diaLabel.Text = "Dia:";
            // 
            // diaDateTimePicker1
            // 
            diaDateTimePicker1.Location = new Point(455, 338);
            diaDateTimePicker1.Name = "diaDateTimePicker1";
            diaDateTimePicker1.Size = new Size(300, 31);
            diaDateTimePicker1.TabIndex = 7;
            // 
            // mesaLabel
            // 
            mesaLabel.AutoSize = true;
            mesaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mesaLabel.Location = new Point(213, 432);
            mesaLabel.Name = "mesaLabel";
            mesaLabel.Size = new Size(174, 32);
            mesaLabel.TabIndex = 8;
            mesaLabel.Text = "Tipo de Mesa:";
            // 
            // tipoComboBox
            // 
            tipoComboBox.FormattingEnabled = true;
            tipoComboBox.Location = new Point(453, 432);
            tipoComboBox.Name = "tipoComboBox";
            tipoComboBox.Size = new Size(302, 33);
            tipoComboBox.TabIndex = 9;
            // 
            // reservarButtton
            // 
            reservarButtton.Location = new Point(384, 531);
            reservarButtton.Name = "reservarButtton";
            reservarButtton.Size = new Size(188, 97);
            reservarButtton.TabIndex = 10;
            reservarButtton.Text = "Reservar";
            reservarButtton.UseVisualStyleBackColor = true;
            // 
            // cantidadErrorLabel
            // 
            cantidadErrorLabel.AutoSize = true;
            cantidadErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cantidadErrorLabel.ForeColor = Color.Red;
            cantidadErrorLabel.Location = new Point(452, 206);
            cantidadErrorLabel.Name = "cantidadErrorLabel";
            cantidadErrorLabel.Size = new Size(0, 25);
            cantidadErrorLabel.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(458, 293);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 12;
            // 
            // diaErrorLabel
            // 
            diaErrorLabel.AutoSize = true;
            diaErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            diaErrorLabel.ForeColor = Color.Red;
            diaErrorLabel.Location = new Point(462, 391);
            diaErrorLabel.Name = "diaErrorLabel";
            diaErrorLabel.Size = new Size(0, 25);
            diaErrorLabel.TabIndex = 13;
            // 
            // tipoErrorLabel
            // 
            tipoErrorLabel.AutoSize = true;
            tipoErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tipoErrorLabel.ForeColor = Color.Red;
            tipoErrorLabel.Location = new Point(459, 479);
            tipoErrorLabel.Name = "tipoErrorLabel";
            tipoErrorLabel.Size = new Size(0, 25);
            tipoErrorLabel.TabIndex = 14;
            // 
            // RestauranteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 702);
            Controls.Add(tipoErrorLabel);
            Controls.Add(diaErrorLabel);
            Controls.Add(label1);
            Controls.Add(cantidadErrorLabel);
            Controls.Add(reservarButtton);
            Controls.Add(tipoComboBox);
            Controls.Add(mesaLabel);
            Controls.Add(diaDateTimePicker1);
            Controls.Add(diaLabel);
            Controls.Add(HoraDateTimePicker);
            Controls.Add(horaLabel);
            Controls.Add(cantidadNumericUpDown);
            Controls.Add(cantidadLabel);
            Controls.Add(tituloLabel);
            Name = "RestauranteForm";
            Text = "RestauranteForm";
            ((System.ComponentModel.ISupportInitialize)cantidadNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label cantidadLabel;
        private NumericUpDown cantidadNumericUpDown;
        private Label horaLabel;
        private DateTimePicker HoraDateTimePicker;
        private Label diaLabel;
        private DateTimePicker diaDateTimePicker1;
        private Label mesaLabel;
        private ComboBox tipoComboBox;
        private Button reservarButtton;
        private Label cantidadErrorLabel;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Label tipoErrorLabel;
        private Label diaErrorLabel;
    }
}