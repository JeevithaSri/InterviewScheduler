using System;
using System.Collections.Generic;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobileno { get; set; }
        public string Skills { get; set; }

        public virtual User User { get; set; }
    }
}
