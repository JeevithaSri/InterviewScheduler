﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CandidateAPI.InterviewSchedulerModel
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateAvailabilities = new HashSet<CandidateAvailability>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Mobileno { get; set; }
        public string Qualification { get; set; }
        public string Email { get; set; }
        public int LevelId { get; set; }
        public int JobId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public byte[] Resume { get; set; }

        public virtual Job Job { get; set; }
        public virtual InterviewLevel Level { get; set; }
        public virtual ICollection<CandidateAvailability> CandidateAvailabilities { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
