using System;
using System.Collections.Generic;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class Panel
    {
        public Panel()
        {
            PanelAvailabilities = new HashSet<PanelAvailability>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobileno { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string JobRole { get; set; }
        public string Level { get; set; }

        public virtual ICollection<PanelAvailability> PanelAvailabilities { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
