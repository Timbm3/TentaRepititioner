using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_3.Models
{
    public class IdiotValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var toCheck = value.ToString().ToLower();
            return !toCheck.Contains("gun") && !toCheck.Contains("knife") && !toCheck.Contains("fight");


        }

        public override string FormatErrorMessage(string name)
        {
            return name + " should not sing about violence";
        }
    }
}
