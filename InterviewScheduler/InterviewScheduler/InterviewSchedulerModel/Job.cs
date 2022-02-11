using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Please enter Job Role")]

        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Enter valid Job ID")]
        [Remote("IsJobIdExist", "Job",
                ErrorMessage = "Job ID already exists")]

        public string JobId { get; set; }


        [Required(ErrorMessage = "Please enter Job Role")]

        [RegularExpression(@"^(?![\W_]+$)(?!\d+$)[a-zA-Z0-9 .&',_-]+$", ErrorMessage = "Enter valid Job Role")]
        public string JobRole { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        [Required(ErrorMessage = "Please enter Available Seats")]
        public int? Available { get; set; }

        public string RecStatus { get; set; } = "A";
        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}
