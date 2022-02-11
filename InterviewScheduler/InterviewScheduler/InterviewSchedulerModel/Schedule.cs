using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Please enter Schedule Name")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select Candidate")]

        public int CandidateId { get; set; }

        [Required(ErrorMessage = "Please Select Panel")]

        public int PanelId { get; set; }

        [Required(ErrorMessage = "Please Select Job Role")]

        public int? JobId { get; set; }

        [Required(ErrorMessage = "Please Select Interview Level")]

        public int LevelId { get; set; }

        [Required(ErrorMessage = "Please enter Date")]

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter TimeFrom")]

        public TimeSpan TimeFrom { get; set; }

        [Required(ErrorMessage = "Please enter TimeTo")]

        public TimeSpan TimeTo { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }


        public virtual Candidate Candidate { get; set; }
        public virtual Job Job { get; set; }
        public virtual InterviewLevel Level { get; set; }
        public virtual Panel Panel { get; set; }
        public virtual ICollection<InterviewStatus> InterviewStatuses { get; set; }
    }
}
