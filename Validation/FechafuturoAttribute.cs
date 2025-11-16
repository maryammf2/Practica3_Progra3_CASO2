using System;
using System.ComponentModel.DataAnnotations;

namespace Practica3_Progra3_CASO2.Validation
{
    public class FechaFuturaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date.Date < DateTime.Today)
                {
                    return new ValidationResult(ErrorMessage ?? "La fecha no puede ser una fecha pasada.");
                }
            }
            return ValidationResult.Success;
        }
    }
}