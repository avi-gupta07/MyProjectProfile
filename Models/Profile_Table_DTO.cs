using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyProjectProfile.Models
{
    public partial class Profile_Table_DTO
    {

        public System.Guid profile_id { get; set; }

        [DisplayName("Email Address*")]
        [Required(ErrorMessage = "This Field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string email_address { get; set; }

        [DisplayName("Greeting*")]
        [Required(ErrorMessage = "This Field is required")]
        public string greeting { get; set; }

        [DisplayName("First Name*")]
        [Required(ErrorMessage = "This Field is required")]
        public string first_name { get; set; }

        [DisplayName("Last Name*")]
        [Required(ErrorMessage = "This Field is required")]
        public string last_name { get; set; }


        [DisplayName("Postal Code*")]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z][-]?\d[A-Za-z]\d$", ErrorMessage = "Incorrect Format")]
        [Required(ErrorMessage = "This Field is required")]
        public string postal_code { get; set; }

        [DisplayName("Primary Phone Number*")]
        [RegularExpression(@"^\+?\d{1,4}[-.()\s]?\d{1,3}[-.()\s]?\d{1,4}[-.()\s]?\d{1,4}[-.()\s]?\d{1,9}$", ErrorMessage = "Incorrect Format")]
        [Required(ErrorMessage = "This Field is required")]
        public string primary_phone_Number { get; set; }

        [DisplayName("Industry Worked")]
        public string Industry_worked { get; set; }


        public string resume_location { get; set; }

      
        //public HttpPostedFileBase Profile_Resume { get; set; }
    }
}