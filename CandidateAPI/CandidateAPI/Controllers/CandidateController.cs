using CandidateAPI.CustomExceptionFilter;
using CandidateAPI.DataLayer;
using CandidateAPI.InterviewSchedulerModel;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class CandidateController : ControllerBase
    {
        private readonly CandidateDataLayer db = new CandidateDataLayer();

        
        [HttpGet("GetAllCandidates")]

        public List<Candidate> GetAllCandidates()
        {
            return db.GetAllCandidates();
        }

        [HttpPost("AddCandidate")]

        public int AddCandidate(Candidate a)
        {

            return db.AddCandidate(a);
        }


        [HttpPut("UpdateCandidate")]

        public int UpdateCandidate(int id, Candidate c)
        {
            return db.UpdateCandidate(id, c);
        }


        [HttpDelete("DeleteCandidate")]

        public int DeleteCandidate(int id)
        {
            return db.DeleteCandidate(id);
        }

        [HttpGet("GetCandidateById/{id}")]

        public Candidate GetCandidateById(int id)
        {
            return db.GetCandidateById(id);
        }


        [HttpGet("GetAllCandidateAvailabilities")]
        public List<CandidateAvailability> GetAllCandidateAvailabilities()
        {
            return db.GetAllCandidateAvailabilities();
        }

        [HttpPost("AddCandidateAvailability")]
        public int AddCandidateAvailability(CandidateAvailability a)
        {

            return db.AddCandidateAvailability(a);
        }

        [HttpPut("UpdateCandidateAvailability")]
        public int UpdateCandidateAvailability(int id, CandidateAvailability c)
        {
            return db.UpdateCandidateAvailability(id, c);
        }

        [HttpDelete("DeleteCandidateAvailability")]
        public int DeleteCandidateAvailability(int id)
        {
            return db.DeleteCandidateAvailability(id);
        }

        [HttpGet("GetCandidateAvailabilityById")]
        public CandidateAvailability GetCandidateAvailabilityById(int id)
        {
            return db.GetCandidateAvailabilityById(id);
        }

       

       

    }
}
