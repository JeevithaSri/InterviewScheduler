using CandidateAPI.CustomExceptionFilter;
using CandidateAPI.DataLayer;
using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using ScheduleAPI.InterviewSchedulerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [CustomExceptionFilter]

    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleDataLayer db = new ScheduleDataLayer();

        [HttpGet("GetAllSchedules")]

        public List<Schedule> GetAllSchedules()
        {
            return db.GetAllSchedules();
        }

        [HttpPost("AddSchedule")]

        public int AddSchedule(Schedule a)
        {

            return db.AddSchedule(a);
        }


        [HttpPut("UpdateSchedule")]

        public int UpdateSchedule(int id, Schedule c)
        {
            return db.UpdateSchedule(id, c);
        }


        [HttpDelete("DeleteSchedule")]

        public int DeleteSchedule(int id)
        {
            return db.DeleteSchedule(id);
        }

        [HttpGet("GetScheduleById")]

        public Schedule GetScheduleById(int id)
        {
            return db.GetScheduleById(id);
        }


        [HttpGet("GetAllInterviewStatuses")]
        public List<InterviewStatus> GetAllInterviewStatuses()
        {
            return db.GetAllInterviewStatuses();
        }

        [HttpPost("AddInterviewStatus")]
        public int AddInterviewStatus(InterviewStatus a)
        {

            return db.AddInterviewStatus(a);
        }

        [HttpPut("UpdateInterviewStatus")]
        public int UpdateInterviewStatus(int id, InterviewStatus c)
        {
            return db.UpdateInterviewStatus(id, c);
        }


        [HttpDelete("DeleteInterviewStatus")]
        public int DeleteInterviewStatus(int id)
        {
            return db.DeleteInterviewStatus(id);
        }


        [HttpGet("{id}/GetInterviewStatusById")]



        public InterviewStatus GetInterviewStatusById(int id)
        {
            return db.GetInterviewStatusById(id);
        }
    }
}
