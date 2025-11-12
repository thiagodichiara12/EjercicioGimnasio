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
    public class NPeriodos
    {   
            private DPeriodos dPeriodos = new DPeriodos();

            //mostrar todos los periodos
            public DataTable Listar()
            {
                return dPeriodos.Listar();
            }

            //buscar periodo por id
            public Periodos Buscar(int id)
            {
                return dPeriodos.Buscar(id);
            }

            //insertar nuevo periodo
            public bool Insertar(Periodos p)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(p.Descripcion))
                        throw new Exception("La descripción no puede estar vacía.");

                    dPeriodos.Insertar(p);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el periodo: " + ex.Message);
                }
            }

            //eliminar periodo por id
            public bool Eliminar(int id)
            {
                try
                {
                    dPeriodos.Eliminar(id);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el periodo: " + ex.Message);
                }
            }
        }
    }


