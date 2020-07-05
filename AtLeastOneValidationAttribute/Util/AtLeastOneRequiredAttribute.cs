using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtLeastOneValidationAttribute.Util
{
    public class AtLeastOneRequiredAttribute : ValidationAttribute
    {
        public string OtherPropertyNames;
        public AtLeastOneRequiredAttribute(string otherPropertyNames)
        {
            OtherPropertyNames = otherPropertyNames;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] propertyNames = OtherPropertyNames.Split(',');
            bool isAllNull = true;
            foreach (var i in propertyNames)
            {
                var p = validationContext.ObjectType.GetProperty(i.Trim());
                var val = p.GetValue(validationContext.ObjectInstance, null);
                if (val != null && val.ToString().Trim() != "")
                {
                    isAllNull = false;
                    break;
                }
            }

            if (isAllNull)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            else
            {
                return null;
            }
        }
    }
}
