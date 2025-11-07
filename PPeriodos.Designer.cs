namespace EjercicioGimnasio
{
    partial class PPeriodos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new EjercicioGimnasio.masterDataSet();
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodosTableAdapter = new EjercicioGimnasio.masterDataSetTableAdapters.PeriodosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdPeriodo = new System.Windows.Forms.TextBox();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "🏋️‍♀️GESTION DE PERIODOS🏋️‍♀️";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPeriodos
            // 
            this.dgvPeriodos.AutoGenerateColumns = false;
            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescripcion});
            this.dgvPeriodos.DataSource = this.periodosBindingSource;
            this.dgvPeriodos.Location = new System.Drawing.Point(395, 107);
            this.dgvPeriodos.Name = "dgvPeriodos";
            this.dgvPeriodos.Size = new System.Drawing.Size(246, 150);
            this.dgvPeriodos.TabIndex = 1;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "Periodos";
            this.periodosBindingSource.DataSource = this.masterDataSet;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar Periodo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdPeriodo
            // 
            this.txtIdPeriodo.Location = new System.Drawing.Point(235, 129);
            this.txtIdPeriodo.Name = "txtIdPeriodo";
            this.txtIdPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPeriodo.TabIndex = 3;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "<--Volver a gestion de planes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(235, 190);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "Refrescar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIdPeriodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPeriodos);
            this.Controls.Add(this.label1);
            this.Name = "PPeriodos";
            this.Text = "PPeriodos";
            this.Load += new System.EventHandler(this.PPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPeriodos;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private masterDataSetTableAdapters.PeriodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}