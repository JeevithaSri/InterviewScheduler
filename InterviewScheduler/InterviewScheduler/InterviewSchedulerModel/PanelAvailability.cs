using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class PanelAvailability
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Panel Name")]

        public int PanelId { get; set; }
       

        [Required(ErrorMessage = "Please enter Available Date")]

        public DateTime AvailableDate { get; set; }

        [Required(ErrorMessage = "Please enter Available Time From")]

        public TimeSpan AvailableTimeFrom { get; set; }

        [Required(ErrorMessage = "Please enter Available Time To")]

        public TimeSpan AvailableTimeTo { get; set; }

    
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Panel Panel { get; set; }
    }
}
