using System.ComponentModel.DataAnnotations;
namespace ADSProject.Models

{
    public class Materia
    {
        public int IdMateria { get; set; }

        public string Nombremateria { get; set; }
        [Required(ErrorMessage = "Este es un campo Requerido")]
        [MaxLength(length: 250, ErrorMessage = "La longitud del campo no puede ser mayor a 254 caracteres.")]
    }
}
