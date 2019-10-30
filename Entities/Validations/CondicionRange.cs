using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Validations {
    class CondicionRange : ValidationAttribute {
        private string[] allowedValues = { "Cursando", "Regular", "Aprobado" };

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (allowedValues.Contains(value.ToString()) == true) {
                return ValidationResult.Success;
            }

            return new ValidationResult("Los valores aceptados son: \"Cursando\", \"Regular\" o \"Aprobado\"");
        }
    }
}
