namespace Temperatura
{
    partial class GbDatosDeTemperatura
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
            this.lblCantidaddegradosCelsius = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnConvertir);
            this.groupBox1.Controls.Add(this.lblRespuesta);
            this.groupBox1.Controls.Add(this.txtCelsius);
            this.groupBox1.Controls.Add(this.lblCantidaddegradosCelsius);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Temperatura";
            // 
            // lblCantidaddegradosCelsius
            // 
            this.lblCantidaddegradosCelsius.AutoSize = true;
            this.lblCantidaddegradosCelsius.Location = new System.Drawing.Point(65, 65);
            this.lblCantidaddegradosCelsius.Name = "lblCantidaddegradosCelsius";
            this.lblCantidaddegradosCelsius.Size = new System.Drawing.Size(274, 25);
            this.lblCantidaddegradosCelsius.TabIndex = 0;
            this.lblCantidaddegradosCelsius.Text = "Cantidad de grados celsius";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(69, 121);
            this.txtCelsius.Multiline = true;
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(507, 22);
            this.txtCelsius.TabIndex = 1;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(65, 186);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(121, 25);
            this.lblRespuesta.TabIndex = 2;
            this.lblRespuesta.Text = "Respuesta:";
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnConvertir.Location = new System.Drawing.Point(712, 87);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(151, 78);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // GbDatosDeTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 509);
            this.Controls.Add(this.groupBox1);
            this.Name = "GbDatosDeTemperatura";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label lblCantidaddegradosCelsius;
        private System.Windows.Forms.Button btnConvertir;
    }
}

