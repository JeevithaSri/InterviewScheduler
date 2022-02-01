using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class User
    {
        public User()
        {
            UserDetails = new HashSet<UserDetail>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter Username"), MaxLength(50)]

      
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        [DataType(DataType.Password, ErrorMessage = "Enter Correct Password")]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    

        public virtual Role Role { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
