namespace segundo_formulario
{
    partial class ContarCaracteres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtCadenaDeTexto = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnContar);
            this.panel1.Controls.Add(this.txtCadenaDeTexto);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Location = new System.Drawing.Point(73, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 251);
            this.panel1.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(18, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(104, 16);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Escribe un texto:";
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRespuesta);
            this.panel2.Location = new System.Drawing.Point(121, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(20, 25);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(73, 16);
            this.lblRespuesta.TabIndex = 0;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // txtCadenaDeTexto
            // 
            this.txtCadenaDeTexto.Location = new System.Drawing.Point(12, 81);
            this.txtCadenaDeTexto.Multiline = true;
            this.txtCadenaDeTexto.Name = "txtCadenaDeTexto";
            this.txtCadenaDeTexto.Size = new System.Drawing.Size(455, 98);
            this.txtCadenaDeTexto.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(492, 103);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(115, 54);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar caracteres";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // ContarCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ContarCaracteres";
            this.Text = "Contador de caracteres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCadenaDeTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnContar;
    }
}

