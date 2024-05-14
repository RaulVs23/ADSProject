﻿using ADSProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdProfesor))]
    public class Profesor
    {
        public string ApellidosProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombresProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este es un Campo requerido")]
        [MinLength(length: 254, ErrorMessage = "La longitud del campo no puede ser a 254 caracteres.")]
        public int IdProfesor { get; set; }


    }
}
