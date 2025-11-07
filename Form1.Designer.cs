namespace EjercicioGimnasio
{
    partial class FormNuevoPlan
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(104, 71);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.Location = new System.Drawing.Point(329, 70);
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtEntrenador.TabIndex = 1;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(534, 70);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.txtEntrenador);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtEntrenador;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}