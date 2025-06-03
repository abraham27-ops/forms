namespace calcular_la_temperatura_faren_
{
    partial class Form1
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
            this.GbTemperatura = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCantidadDeGradosFarenheit = new System.Windows.Forms.Label();
            this.txtFaren = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.GbTemperatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbTemperatura
            // 
            this.GbTemperatura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbTemperatura.Controls.Add(this.btnConvertir);
            this.GbTemperatura.Controls.Add(this.lblRespuesta);
            this.GbTemperatura.Controls.Add(this.txtFaren);
            this.GbTemperatura.Controls.Add(this.lblCantidadDeGradosFarenheit);
            this.GbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTemperatura.Location = new System.Drawing.Point(34, 52);
            this.GbTemperatura.Name = "GbTemperatura";
            this.GbTemperatura.Size = new System.Drawing.Size(936, 243);
            this.GbTemperatura.TabIndex = 0;
            this.GbTemperatura.TabStop = false;
            this.GbTemperatura.Text = "Datos de Temperatura";
            // 
            // lblCantidadDeGradosFarenheit
            // 
            this.lblCantidadDeGradosFarenheit.AutoSize = true;
            this.lblCantidadDeGradosFarenheit.Location = new System.Drawing.Point(40, 54);
            this.lblCantidadDeGradosFarenheit.Name = "lblCantidadDeGradosFarenheit";
            this.lblCantidadDeGradosFarenheit.Size = new System.Drawing.Size(298, 25);
            this.lblCantidadDeGradosFarenheit.TabIndex = 0;
            this.lblCantidadDeGradosFarenheit.Text = "Cantidad de grados Farenheit";
            // 
            // txtFaren
            // 
            this.txtFaren.Location = new System.Drawing.Point(45, 104);
            this.txtFaren.Multiline = true;
            this.txtFaren.Name = "txtFaren";
            this.txtFaren.Size = new System.Drawing.Size(399, 22);
            this.txtFaren.TabIndex = 1;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(56, 185);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(121, 25);
            this.lblRespuesta.TabIndex = 2;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConvertir.Location = new System.Drawing.Point(516, 54);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(114, 104);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 519);
            this.Controls.Add(this.GbTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbTemperatura.ResumeLayout(false);
            this.GbTemperatura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbTemperatura;
        private System.Windows.Forms.TextBox txtFaren;
        private System.Windows.Forms.Label lblCantidadDeGradosFarenheit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

