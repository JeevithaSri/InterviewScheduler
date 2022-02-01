using System;
using System.Collections.Generic;

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
        public string Level { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
