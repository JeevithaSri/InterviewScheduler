using System;
using System.Collections.Generic;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class Job
    {
        public Job()
        {
            Candidates = new HashSet<Candidate>();
            Panels = new HashSet<Panel>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string JobRole { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? Available { get; set; }
        public string JobId { get; set; }
        public string RecStatus { get; set; } = "A";

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Panel> Panels { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
