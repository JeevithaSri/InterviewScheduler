﻿using CandidateAPI.CustomExceptionFilter;
using CandidateAPI.DataLayer;
using CandidateAPI.InterviewSchedulerModel;
//using JobAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Threading.Tasks;

namespace JobAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [CustomExceptionFilter]
    public class JobController : ControllerBase
    {
        private readonly JobDataLayer db = new JobDataLayer();



        [HttpGet("GetAllJobs")]

        public List<Job> GetAllJobs()
        {
            return db.GetAllJobs();
        }

        [HttpPost("AddJob")]

        public int AddJob(Job a)
        {

            return db.AddJob(a);
        }


        [HttpPut("UpdateJob")]

        public int UpdateJob(int id, Job c)
        {
            return db.UpdateJob(id, c);
        }


        [HttpDelete("DeleteJob")]

        public int DeleteJob(int id)
        {
            return db.DeleteJob(id);
        }


        [CustomExceptionFilter]


        [HttpGet("GetJobById/{id}")]
        

        public Job GetJobById(int id)
        {

            return db.GetJobById(id);

            
            //if (db == null)
            //{
            //    var message = string.Format("Product with id = {0} not found", id);
            //    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            //}
            //else
            //{
            //    return Request.CreateResponse(HttpStatusCode.OK, db);
            //}



        }


        [HttpGet("GetAllInterviewLevels")]
        public List<InterviewLevel> GetAllInterviewLevels()
        {
            return db.GetAllInterviewLevels();
        }

        [HttpPost("AddInterviewLevel")]
        public int AddInterviewLevel(InterviewLevel a)
        {

            return db.AddInterviewLevel(a);
        }

        [HttpPut("UpdateInterviewLevel")]
        public int UpdateInterviewLevel(int id, InterviewLevel c)
        {
            return db.UpdateInterviewLevel(id, c);
        }


        [HttpDelete("DeleteInterviewLevel")]
        public int DeleteInterviewLevel(int id)
        {
            return db.DeleteInterviewLevel(id);
        }


        [HttpGet("{id}/GetInterviewLevelById")]

        

        public InterviewLevel GetInterviewLevelById(int id)
        {
            return db.GetInterviewLevelById(id);
        }
    }
}
