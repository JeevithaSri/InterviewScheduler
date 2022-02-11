using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateAvailabilities = new HashSet<CandidateAvailability>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name")]

        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Enter valid Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter DOB")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Enter valid Address")]

        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter Mobile Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Enter valid Mobile Number")]
        public string Mobileno { get; set; }

        [Required(ErrorMessage = "Please enter Qualification")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Enter valid Email Address")]


        public string Email { get; set; }

        [Required(ErrorMessage = "Please select Interview Level")]

        public int LevelId { get; set; }

        [Required(ErrorMessage = "Please select Job Role")]

        public int JobId { get; set; }

        [Required(ErrorMessage = "Please enter Interview Status")]

        public string Status { get; set; }



        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        [Required(ErrorMessage = "Please Upload a File")]

        public string Resume { get; set; }

        public virtual Job Job { get; set; }
        public virtual InterviewLevel Level { get; set; }
        public virtual ICollection<CandidateAvailability> CandidateAvailabilities { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
