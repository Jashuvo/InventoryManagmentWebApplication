//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace InventoryManagmentWebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [Key]
        public int u_id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "*")]
        public string u_name { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "*")]
        public string u_username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string u_password { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^((\+880-?)|0)?[0-9]{10}$", ErrorMessage = "Entered phone format is not valid.")]
        public string u_phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string u_email { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "*")]
        public byte u_status { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "*")]
        public byte u_roleID { get; set; }
    
        public virtual role role { get; set; }
    }
}

