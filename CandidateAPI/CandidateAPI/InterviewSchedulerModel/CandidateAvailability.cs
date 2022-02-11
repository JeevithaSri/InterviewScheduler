using System;
using System.Collections.Generic;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class CandidateAvailability
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public DateTime AvailableDate { get; set; }
        public TimeSpan AvailableTimeFrom { get; set; }
        public TimeSpan AvailableTimeTo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Candidate Candidate { get; set; }
    }
}
