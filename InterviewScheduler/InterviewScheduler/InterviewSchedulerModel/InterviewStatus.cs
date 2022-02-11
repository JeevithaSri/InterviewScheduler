using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class InterviewStatus
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Schedule Name")]

        public int ScheduleId { get; set; }

        [Required(ErrorMessage = "Please enter Interview Status")]

        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Enter valid Interview Status")]


        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
