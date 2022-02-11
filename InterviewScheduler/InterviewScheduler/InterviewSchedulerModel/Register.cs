using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.InterviewSchedulerModel
{
    public class Register
    {
        public Register()
        {
            UserDetails = new HashSet<UserDetail>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Role name")]
        public int RoleId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Username"), MaxLength(50)]

        

        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Username should be alphanumeric")]

        [Remote("IsUserNameExist", "Login",
                ErrorMessage = "Username name already exists")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Password")]

        [RegularExpression(@"^.{8,}$", ErrorMessage = "The Password should be atleast 8 characters")]

       
        [DataType(DataType.Password, ErrorMessage = "Enter Correct Password")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm password")]

        [Compare("Password", ErrorMessage = "Password and Confirm Password did not match")]

        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }


        public virtual Role Role { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
