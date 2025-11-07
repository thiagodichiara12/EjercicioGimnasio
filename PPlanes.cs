using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioGimnasio
{
    public partial class PPlanes : Form
    {
        public PPlanes()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtIdPlan.Text, out int idPlan))
            {
                MessageBox.Show("Ingrese un Id válido");
                return;
            }

            using (SqlConnection cn = Db.GetConnection())
            {
                cn.Open();

               
                string query = @"
            SELECT p.Id, p.Cliente, p.Entrenador, pe.Descripcion AS Periodo
            FROM Planes p
            INNER JOIN Periodos pe ON p.PeriodoId = pe.Id
            WHERE p.Id = @id";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", idPlan);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvPlanes.AutoGenerateColumns = false;
                colId.DataPropertyName = "Id";
                colCliente.DataPropertyName = "Cliente";
                colEntrenador.DataPropertyName = "Entrenador";
                colPeriodo.DataPropertyName = "Periodo";
                dgvPlanes.DataSource = dt;


                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró un plan con ese Id");
                    dgvPlanes.DataSource = null;
                }
                else
                {
                    dgvPlanes.DataSource = dt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormNuevoPlan form = new FormNuevoPlan())
            {
                form.ShowDialog(); 
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = Db.GetConnection())
                {
                    cn.Open();
                    string query = @"
                SELECT p.Id, p.Cliente, p.Entrenador, pe.Descripcion AS Periodo
                FROM Planes p
                INNER JOIN Periodos pe ON p.PeriodoId = pe.Id";

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    da.Fill(dt);

                    dgvPlanes.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un plan para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPlan = Convert.ToInt32(dgvPlanes.CurrentRow.Cells["colId"].Value);

            var resultado = MessageBox.Show("¿Está seguro que desea eliminar este plan?",
                                            "Confirmar eliminación",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection cn = Db.GetConnection())
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Planes WHERE Id = @id", cn);
                        cmd.Parameters.AddWithValue("@id", idPlan);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                            MessageBox.Show("Plan eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se pudo eliminar el plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el plan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPeriodos_Click(object sender, EventArgs e)
        {
            using (PPeriodos formPeriodos = new PPeriodos())
            {
                formPeriodos.ShowDialog(); 
            }
        }
    }
}