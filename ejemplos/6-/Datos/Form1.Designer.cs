namespace Datos
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
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbluno = new System.Windows.Forms.Label();
            this.txtuno = new System.Windows.Forms.TextBox();
            this.lbldos = new System.Windows.Forms.Label();
            this.txtdos = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.GbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDatos
            // 
            this.GbDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbDatos.Controls.Add(this.btnDivision);
            this.GbDatos.Controls.Add(this.btnRestar);
            this.GbDatos.Controls.Add(this.btnMultiplicacion);
            this.GbDatos.Controls.Add(this.btnSuma);
            this.GbDatos.Controls.Add(this.lblResultado);
            this.GbDatos.Controls.Add(this.txtdos);
            this.GbDatos.Controls.Add(this.lbldos);
            this.GbDatos.Controls.Add(this.txtuno);
            this.GbDatos.Controls.Add(this.lbluno);
            this.GbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatos.Location = new System.Drawing.Point(22, 34);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(966, 289);
            this.GbDatos.TabIndex = 0;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos";
            // 
            // lbluno
            // 
            this.lbluno.AutoSize = true;
            this.lbluno.Location = new System.Drawing.Point(47, 44);
            this.lbluno.Name = "lbluno";
            this.lbluno.Size = new System.Drawing.Size(136, 25);
            this.lbluno.TabIndex = 0;
            this.lbluno.Text = "Numero uno:";
            // 
            // txtuno
            // 
            this.txtuno.Location = new System.Drawing.Point(52, 84);
            this.txtuno.Multiline = true;
            this.txtuno.Name = "txtuno";
            this.txtuno.Size = new System.Drawing.Size(188, 22);
            this.txtuno.TabIndex = 1;
            // 
            // lbldos
            // 
            this.lbldos.AutoSize = true;
            this.lbldos.Location = new System.Drawing.Point(47, 140);
            this.lbldos.Name = "lbldos";
            this.lbldos.Size = new System.Drawing.Size(135, 25);
            this.lbldos.TabIndex = 2;
            this.lbldos.Text = "Numero dos:";
            this.lbldos.Click += new System.EventHandler(this.lbldos_Click);
            // 
            // txtdos
            // 
            this.txtdos.Location = new System.Drawing.Point(52, 193);
            this.txtdos.Multiline = true;
            this.txtdos.Name = "txtdos";
            this.txtdos.Size = new System.Drawing.Size(188, 22);
            this.txtdos.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(397, 132);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSuma.Location = new System.Drawing.Point(740, 29);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(126, 56);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiplicacion.Location = new System.Drawing.Point(740, 153);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(126, 56);
            this.btnMultiplicacion.TabIndex = 6;
            this.btnMultiplicacion.Text = "Multiplicacion";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRestar.Location = new System.Drawing.Point(740, 91);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(126, 56);
            this.btnRestar.TabIndex = 7;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDivision.Location = new System.Drawing.Point(740, 215);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(126, 56);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "Dividir";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 525);
            this.Controls.Add(this.GbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Label lbldos;
        private System.Windows.Forms.TextBox txtuno;
        private System.Windows.Forms.Label lbluno;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtdos;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
    }
}

