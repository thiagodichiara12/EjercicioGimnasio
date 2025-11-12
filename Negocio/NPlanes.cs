using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPlanes
    {
        private DPlanes dPlanes = new DPlanes();

        //mostrar todos los planes
        public DataTable Listar()
        {
            return dPlanes.Listar();
        }

        // buscar plan por id
        public Planes Buscar(int id)
        {
            return dPlanes.Buscar(id);
        }

        // insertar nuevo plan
        public bool Insertar(Planes plan)
        {
            try
            {
                if (plan.cliente == null || plan.cliente.id <= 0)
                    throw new Exception("Debe seleccionar un cliente válido.");
                if (plan.periodo == null || plan.periodo.id <= 0)
                    throw new Exception("Debe seleccionar un periodo válido.");
                if (plan.entrenador == null || plan.entrenador.id <= 0)
                    throw new Exception("Debe seleccionar un entrenador válido.");

                dPlanes.Insertar(plan);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el plan: " + ex.Message);
            }
        }

        // eliminar plan por id
        public bool Eliminar(int id)
        {
            try
            {
                dPlanes.Eliminar(id);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el plan: " + ex.Message);
            }
        }
    }
}
