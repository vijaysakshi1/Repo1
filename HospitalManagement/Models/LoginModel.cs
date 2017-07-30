using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BusinessLayer;

namespace HospitalManagement.Models
{
    public class LoginModel
    {
        AdminFacade objAdmin = new AdminFacade();

        [Display(Name ="User Name")]
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        

        public bool IsValidAdmin( LoginModel model)
        {
            return objAdmin.IsValidAdmin(model.UserName, model.Password);

        }

    }
    public class Register:LoginModel 
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]

        public string ConfirmPassword { get; set; }

        [Required]
        public string Image { get; set; }


    }
}