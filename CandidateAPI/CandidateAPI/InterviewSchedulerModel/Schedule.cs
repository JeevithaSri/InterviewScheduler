using System;
using System.Collections.Generic;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class Schedule
    {
        public Schedule()
        {
            InterviewStatuses = new HashSet<InterviewStatus>();
        }

        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int PanelId { get; set; }
        public int LevelId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? JobId { get; set; }
        public string Name { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Job Job { get; set; }
        public virtual InterviewLevel Level { get; set; }
        public virtual Panel Panel { get; set; }
        public virtual ICollection<InterviewStatus> InterviewStatuses { get; set; }
    }
}
