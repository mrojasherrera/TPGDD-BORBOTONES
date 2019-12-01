namespace FrbaOfertas.CargaCredito
{
    partial class Cargar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DniCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoPago = new System.Windows.Forms.ComboBox();
            this.Monto = new System.Windows.Forms.NumericUpDown();
            this.DatoTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CargarBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Monto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DniCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TipoPago);
            this.groupBox1.Controls.Add(this.Monto);
            this.groupBox1.Controls.Add(this.DatoTarjeta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar crédito";
            // 
            // DniCB
            // 
            this.DniCB.DisplayMember = "Cli_Dni";
            this.DniCB.FormattingEnabled = true;
            this.DniCB.Location = new System.Drawing.Point(224, 150);
            this.DniCB.Name = "DniCB";
            this.DniCB.Size = new System.Drawing.Size(166, 21);
            this.DniCB.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "DNI:";
            // 
            // TipoPago
            // 
            this.TipoPago.DisplayMember = "Tipo_Pago_Desc";
            this.TipoPago.FormattingEnabled = true;
            this.TipoPago.Location = new System.Drawing.Point(224, 33);
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Size = new System.Drawing.Size(167, 21);
            this.TipoPago.TabIndex = 16;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(224, 72);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(166, 20);
            this.Monto.TabIndex = 15;
            // 
            // DatoTarjeta
            // 
            this.DatoTarjeta.Location = new System.Drawing.Point(224, 113);
            this.DatoTarjeta.Name = "DatoTarjeta";
            this.DatoTarjeta.Size = new System.Drawing.Size(166, 20);
            this.DatoTarjeta.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "DATOS DE TARJETA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "MONTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIPO DE PAGO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(438, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CargarBtn
            // 
            this.CargarBtn.Location = new System.Drawing.Point(263, 238);
            this.CargarBtn.Name = "CargarBtn";
            this.CargarBtn.Size = new System.Drawing.Size(95, 41);
            this.CargarBtn.TabIndex = 10;
            this.CargarBtn.Text = "Cargar";
            this.CargarBtn.UseVisualStyleBackColor = true;
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(123, 238);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(95, 41);
            this.VolverBtn.TabIndex = 9;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // Cargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 298);
            this.Controls.Add(this.CargarBtn);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cargar";
            this.Text = "Cargar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Monto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DniCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoPago;
        private System.Windows.Forms.NumericUpDown Monto;
        private System.Windows.Forms.TextBox DatoTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CargarBtn;
        private System.Windows.Forms.Button VolverBtn;
    }
}