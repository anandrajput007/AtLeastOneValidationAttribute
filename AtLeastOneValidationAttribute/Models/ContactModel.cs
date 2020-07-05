using AtLeastOneValidationAttribute.Util;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtLeastOneValidationAttribute.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Full Name is Required.")]
        public string FullName { get; set; }

        [AtLeastOneRequiredAttribute("UserName, EmailID, MobileNo", ErrorMessage = "At Leaset one required of UserName/EmailID/MobileNo")]
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public DateTime DOB { get; set; }
    }
}
