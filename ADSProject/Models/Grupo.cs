using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Grupo
    {
        public int IdGrupo { get; set; }

        public int IdCarrera { get; set; }
        [Required(ErrorMessage = "Este es un campo Requerido")]

        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este es un campo Requerido")]

        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo Requerido")]

        public int Ciclo { get; set; }
        [Required(ErrorMessage = "Este es un campo Requerido")]

        public int Anio { get; set;}
        [Required(ErrorMessage = "Este es un campo Requerido")]
    }
}
