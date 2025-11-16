using System;
using System.ComponentModel.DataAnnotations;
using Practica3_Progra3_CASO2.Validation;

namespace Practica3_Progra3_CASO2.Models
{
    public enum TallerOpcion
    {
        [Display(Name = "Seleccione un taller...")]
        Ninguno = 0,
        [Display(Name = "C#")]
        CSharp,
        [Display(Name = "Python")]
        Python,
        [Display(Name = "Web")]
        Web,
        [Display(Name = "Bases de Datos")]
        BasesDeDatos,
        [Display(Name = "Otro")]
        Otro
    }

    public enum NivelOpcion
    {
        [Display(Name = "Seleccione un nivel...")]
        Ninguno = 0,
        [Display(Name = "Principiante")]
        Principiante,
        [Display(Name = "Intermedio")]
        Intermedio,
        [Display(Name = "Avanzado")]
        Avanzado
    }


    public class Inscripcion
    {
        [Required(ErrorMessage = "El Nombre del participante es obligatorio.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El Nombre debe tener entre 2 y 20 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los Apellidos son obligatorios.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Los Apellidos deben tener entre 2 y 20 caracteres.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El Correo electronico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del Correo electronico no es valido.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        [RegularExpression(@"^[\d\s\-\(\)\+]{9,}$", ErrorMessage = "El Teléfono debe contener al menos 9 dígitos.")]
        [StringLength(20, ErrorMessage = "El Teléfono no puede exceder los 20 caracteres.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debes seleccionar un Taller.")]
        [Range(1, int.MaxValue, ErrorMessage = "No se permite la opción por defecto 'Seleccione un taller…'.")]
        public TallerOpcion TallerSeleccionado { get; set; }

        [Required(ErrorMessage = "El Nivel de Experiencia es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un Nivel de Experiencia.")]
        public NivelOpcion NivelExperiencia { get; set; }

        [Required(ErrorMessage = "La Fecha del Taller es obligatoria.")]
        [DataType(DataType.Date)]
        [FechaFutura(ErrorMessage = "La Fecha del Taller no puede ser una fecha pasada (debe ser hoy o una fecha futura).")]
        public DateTime FechaTaller { get; set; }

        [Required(ErrorMessage = "Debe aceptar los términos y condiciones para completar la inscripción.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe aceptar los términos y condiciones para completar la inscripción.")]
        public bool AceptaTerminos { get; set; }
    }
}
