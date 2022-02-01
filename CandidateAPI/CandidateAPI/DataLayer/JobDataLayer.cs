using CandidateAPI.InterviewSchedulerModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.DataLayer
{
    [CustomExceptionFilter.CustomExceptionFilter]
    public class JobDataLayer
    {
        private readonly InterviewScheduleContext db = new InterviewScheduleContext();

        
        public List<Job> GetAllJobs()
        {
            return db.Jobs.ToList();
        }

        public int AddJob(Job a)
        {
            db.Jobs.Add(a);

            return db.SaveChanges();
        }

        public int UpdateJob(int id, Job c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteJob(int id)
        {
            Job b = GetJobById(id);
            db.Jobs.Remove(b);
            return db.SaveChanges();
        }

        [CustomExceptionFilter.CustomExceptionFilter]

        public Job GetJobById(int id)
        {
            Job c = db.Jobs.Find(id);
            return c;
        }



        public List<InterviewLevel> GetAllInterviewLevels()
        {
            return db.InterviewLevels.ToList();
        }

        public int AddInterviewLevel(InterviewLevel a)
        {
            db.InterviewLevels.Add(a);

            return db.SaveChanges();
        }

        public int UpdateInterviewLevel(int id, InterviewLevel c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteInterviewLevel(int id)
        {
            InterviewLevel b = GetInterviewLevelById(id);
            db.InterviewLevels.Remove(b);
            return db.SaveChanges();
        }


        public InterviewLevel GetInterviewLevelById(int id)
        {
            InterviewLevel c = db.InterviewLevels.Find(id);
            return c;
        }

    }
}
