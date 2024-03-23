using ADSProject.Interfaces;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ADSProject.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarreras = new List<Carrera>
        {
            new Carrera
            {
                IdCarrera = 1,
                Codigo = "PS24I04002",
                NombreCarrera = "Ingeniería de Sistemas"
            }
        };

        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                int indice = lstCarreras.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                lstCarreras[indice] = carrera;
                return idCarrera;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                if (lstCarreras.Count > 0)
                {
                    carrera.IdCarrera = lstCarreras.Last().IdCarrera + 1;
                }

                lstCarreras.Add(carrera);

                return carrera.IdCarrera;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                int indice = lstCarreras.FindIndex(tmp => tmp.IdCarrera == idCarrera);
                lstCarreras.RemoveAt(indice);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrera ObtenerCarreraPorID(int idCarrera)
        {
            try
            {
                Carrera carrera = lstCarreras.FirstOrDefault(tmp => tmp.IdCarrera == idCarrera);
                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Carrera> ObtenerTodosLasCarreras()
        {
            try
            {
                return lstCarreras;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
