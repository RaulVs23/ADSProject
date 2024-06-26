﻿using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombresEstudiantes = "Juan Carlos",
            ApellidosEstudiante = "Perez Sosa", CodigoEstudiante = "PS24I04002",
            CorreoEstudiante = "PS24I04002@usonsonate.edu.sv"

            }
        };

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiantes[indice] = estudiante;

                return idEstudiante;
            }
            catch (Exception) 
            {
                throw;
            }
        }


        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }
                lstEstudiantes.Add(estudiante);
                return estudiante.IdEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool EliminarEstudiante(int IdEstudiante)
        {
            try
            {
                // ontenemos el indice del objeto a eliminar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == IdEstudiante);
                // procedemos a eliminar el registro
                lstEstudiantes.RemoveAt(indice);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante ObtenerEstudiantesPorID(int IdEstudiante)
        {
            try 
            {
                Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == IdEstudiante);

                return estudiante;
            }
            catch 
            {
                throw;
            }
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            try 
            {
                return lstEstudiantes;
            
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
