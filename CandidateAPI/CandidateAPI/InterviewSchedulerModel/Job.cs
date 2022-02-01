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
        }

        public int Id { get; set; }
        public string JobRole { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? Available { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}
