using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ModelValidation.Models.Attributes;

namespace ModelValidation.Models
{   //[NoGarfieldOnMondays(ErrorMessage = "NO GRAMFEL")]
    public class Appointment : IValidatableObject
    {
        //[Required]
        public string ClientName  { get; set; }

        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Pick a date, please.")]
        //[FutureDate(ErrorMessage = "Please enter a date in the future.")]
        public DateTime Date { get; set; }
        //[Range(typeof(bool), "true", "true", ErrorMessage = "Please click the check box.")]
       // [MustBeTrue(ErrorMessage = "This must be accepted.")]
        public bool TermsAccepted { get; set; }
        //[Range(typeof(decimal), "0.25", "8", ErrorMessage = "Minimum appointment time is 15 minutes; maximum is 8 hours.")]
        public decimal Time { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(ClientName))
            {
                errors.Add(new ValidationResult("Please enter name", new [] {"ClientName"}));
            }

            if (DateTime.Now > Date)
            {
                errors.Add(new ValidationResult("Need a date in the future", new [] {"Date"}));
            }

            if (errors.Count == 0 && ClientName == "Garfield" && Date.DayOfWeek == DayOfWeek.Monday)
            {
                errors.Add(new ValidationResult("No mondays, Garfield."));
            }

            if (!TermsAccepted)
            {
                errors.Add(new ValidationResult("Accept TaC"));
            }
            return errors;
        }
    }
}