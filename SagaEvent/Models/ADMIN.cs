namespace SagaEvent.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class ADMIN
    {
        public int adminID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string adminEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Password")]
        public string adminPassword { get; set; }
    }
}
