namespace EjercicioGimnasio
{
    partial class PPlanes
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
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtIdPlan = new System.Windows.Forms.TextBox();
            this.btnPeriodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCliente,
            this.colPeriodo,
            this.colEntrenador});
            this.dgvPlanes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPlanes.Location = new System.Drawing.Point(76, 56);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.Size = new System.Drawing.Size(908, 250);
            this.dgvPlanes.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colPeriodo
            // 
            this.colPeriodo.HeaderText = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            // 
            // colEntrenador
            // 
            this.colEntrenador.HeaderText = "Entrenador";
            this.colEntrenador.Name = "colEntrenador";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "💪GESTION DE PLANES💪";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtIdPlan
            // 
            this.txtIdPlan.Location = new System.Drawing.Point(163, 359);
            this.txtIdPlan.Name = "txtIdPlan";
            this.txtIdPlan.Size = new System.Drawing.Size(100, 20);
            this.txtIdPlan.TabIndex = 7;
            // 
            // btnPeriodos
            // 
            this.btnPeriodos.Location = new System.Drawing.Point(733, 351);
            this.btnPeriodos.Name = "btnPeriodos";
            this.btnPeriodos.Size = new System.Drawing.Size(187, 30);
            this.btnPeriodos.TabIndex = 8;
            this.btnPeriodos.Text = "Acceder a la gestion de periodos -->";
            this.btnPeriodos.UseVisualStyleBackColor = true;
            this.btnPeriodos.Click += new System.EventHandler(this.btnPeriodos_Click);
            // 
            // PPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 506);
            this.Controls.Add(this.btnPeriodos);
            this.Controls.Add(this.txtIdPlan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPlanes);
            this.Controls.Add(this.label1);
            this.Name = "PPlanes";
            this.Text = "Acceder a la gestion de periodos -->";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrenador;
        private System.Windows.Forms.Button btnPeriodos;
    }
}