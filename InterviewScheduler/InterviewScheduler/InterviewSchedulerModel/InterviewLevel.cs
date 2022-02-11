using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class InterviewLevel
    {
        public InterviewLevel()
        {
            Candidates = new HashSet<Candidate>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Interview Level")]
        public string Level { get; set; }
      

        [Required(ErrorMessage = "Please enter Description")]
        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Enter valid Description")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
