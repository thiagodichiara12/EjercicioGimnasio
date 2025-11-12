using Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPlanes
    {
        private string connectionString =
            "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TP2-LP1-202402;Integrated Security=True;TrustServerCertificate=True";

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // mostrar todos los planes
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = GetConnection())
            {
                string query = @"
                    SELECT p.Id, c.Id AS ClienteId, pe.Id AS PeriodoId, e.Id AS EntrenadorId
                    FROM Planes p
                    INNER JOIN Clientes c ON p.ClienteId = c.Id
                    INNER JOIN Periodos pe ON p.PeriodoId = pe.Id
                    INNER JOIN Entrenadores e ON p.EntrenadorId = e.Id";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(dt);
            }
            return dt;
        }

        // buscar un plan por id
        public Planes Buscar(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = @"
                    SELECT p.Id, c.Id AS ClienteId, pe.Id AS PeriodoId, e.Id AS EntrenadorId
                    FROM Planes p
                    INNER JOIN Clientes c ON p.ClienteId = c.Id
                    INNER JOIN Periodos pe ON p.PeriodoId = pe.Id
                    INNER JOIN Entrenadores e ON p.EntrenadorId = e.Id
                    WHERE p.Id = @id";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Planes
                    {
                        id = dr.GetInt32(0),
                        cliente = new Clientes { id = dr.GetInt32(1) },
                        periodo = new Periodos { id = dr.GetInt32(2) },
                        entrenador = new Entrenadores { id = dr.GetInt32(3) }
                    };
                }
            }
            return null;
        }

        // insertar un nuevo plan
        public bool Insertar(Planes plan)
        {
            try
            {
                using (SqlConnection cn = GetConnection())
                {
                    string query = @"
                        INSERT INTO Planes (ClienteId, PeriodoId, EntrenadorId)
                        VALUES (@clienteId, @periodoId, @entrenadorId)";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@clienteId", plan.cliente.id);
                    cmd.Parameters.AddWithValue("@periodoId", plan.periodo.id);
                    cmd.Parameters.AddWithValue("@entrenadorId", plan.entrenador.id);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar plan: " + ex.Message);
            }
        }

        //eliminar un plan por id
        public bool Eliminar(int id)
        {
            try
            {
                using (SqlConnection cn = GetConnection())
                {
                    string query = "DELETE FROM Planes WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar plan: " + ex.Message);
            }
        }
    }
}
    

