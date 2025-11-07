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
    public partial class PPeriodos : Form
    {
        public PPeriodos()
        {
            InitializeComponent();
        }

        private void PPeriodos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.masterDataSet.Periodos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPeriodo.Text.Trim(), out int idPeriodo))
            {
                MessageBox.Show("Ingrese un Id válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = Db.GetConnection())
                {
                    cn.Open();

                    string query = "SELECT Id, Descripcion FROM Periodos WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", idPeriodo);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró un periodo con ese Id", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPeriodos.DataSource = null;
                    }
                    else
                    {
                        dgvPeriodos.AutoGenerateColumns = false;
                        colId.DataPropertyName = "Id";
                        colDescripcion.DataPropertyName = "Descripcion";
                        dgvPeriodos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el periodo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) //volver a gestion de planes
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //guardar
        {
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Ingrese una descripción válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = Db.GetConnection())
                {
                    cn.Open();
                    string query = "INSERT INTO Periodos (Descripcion) VALUES (@descripcion)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Periodo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el periodo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarPeriodos()
        {
            try
            {
                using (SqlConnection cn = Db.GetConnection())
                {
                    cn.Open();
                    string query = "SELECT Id, Descripcion FROM Periodos";
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPeriodos.AutoGenerateColumns = false;
                    colId.DataPropertyName = "Id";
                    colDescripcion.DataPropertyName = "Descripcion";
                    dgvPeriodos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar periodos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e) //refrescar
        {
            RefrescarPeriodos();
        }

        private void button5_Click(object sender, EventArgs e) //eliminar
        {
            if (dgvPeriodos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un periodo para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPeriodo = Convert.ToInt32(dgvPeriodos.SelectedRows[0].Cells["colId"].Value);
            using (SqlConnection cn = Db.GetConnection())
            {
                cn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Planes WHERE PeriodoId = @id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, cn);
                checkCmd.Parameters.AddWithValue("@id", idPeriodo);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("No se puede eliminar este periodo porque tiene planes asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el periodo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection cn = Db.GetConnection())
                    {
                        cn.Open();
                        string query = "DELETE FROM Periodos WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", idPeriodo);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Periodo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarPeriodos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el periodo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
   
    }

}
   

