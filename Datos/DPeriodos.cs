using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPeriodos
    {
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TP2-LP1-202402;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Id, Descripcion FROM Periodos";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(dt);
            }
            return dt;
        }

        public Periodos Buscar(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Id, Descripcion FROM Periodos WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Periodos
                    {
                        id = dr.GetInt32(0),
                        Descripcion = dr.GetString(1)
                    };
                }
            }

            return null;
        }

        public void Insertar(Periodos p)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "INSERT INTO Periodos (Descripcion) VALUES (@descripcion)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "DELETE FROM Periodos WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}


