using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioGimnasio
{
    public partial class FormNuevoPlan : Form
    {
        public FormNuevoPlan()
        {
            InitializeComponent();
            CargarPeriodos();
        }
        private void CargarPeriodos()
        {
            using (SqlConnection cn = Db.GetConnection())
            {
                cn.Open();
                string query = "SELECT Id, Descripcion FROM Periodos";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbPeriodo.DataSource = dt;
                cmbPeriodo.DisplayMember = "Descripcion"; 
                cmbPeriodo.ValueMember = "Id";           
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text.Trim();
            string entrenador = txtEntrenador.Text.Trim();
            int periodoId = Convert.ToInt32(cmbPeriodo.SelectedValue);

            using (SqlConnection cn = Db.GetConnection())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Planes (Cliente, PeriodoId, Entrenador) VALUES (@cliente, @periodo, @entrenador)", cn);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@periodo", periodoId);
                cmd.Parameters.AddWithValue("@entrenador", entrenador);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Plan guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();     
        }

    } 
}

