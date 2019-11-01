using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validations {
    public class RolRangeAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {

            if (Persona.Roles.Contains(value.ToString())) {
                return ValidationResult.Success;
            }

            return new ValidationResult("Los roles son: \"Alumno\", \"Docente\" y \"No Docente\"");
        }
    }
}