using System;
using System.Collections.Generic;

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
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
