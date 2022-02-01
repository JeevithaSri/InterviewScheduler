using CandidateAPI.InterviewSchedulerModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.DataLayer
{

    [CustomExceptionFilter.CustomExceptionFilter]

    public class ScheduleDataLayer
    {
        private readonly InterviewScheduleContext db = new InterviewScheduleContext();

        public List<Schedule> GetAllSchedules()
        {
            return db.Schedules.ToList();
        }

        public int AddSchedule(Schedule a)
        {
            db.Schedules.Add(a);

            return db.SaveChanges();
        }

        public int UpdateSchedule(int id, Schedule c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteSchedule(int id)
        {
            Schedule b = GetScheduleById(id);
            db.Schedules.Remove(b);
            return db.SaveChanges();
        }


        public Schedule GetScheduleById(int id)
        {
            Schedule c = db.Schedules.Find(id);
            return c;
        }


        public List<InterviewStatus> GetAllInterviewStatuses()
        {
            return db.InterviewStatuses.ToList();
        }

        public int AddInterviewStatus(InterviewStatus a)
        {
            db.InterviewStatuses.Add(a);

            return db.SaveChanges();
        }

        public int UpdateInterviewStatus(int id, InterviewStatus c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteInterviewStatus(int id)
        {
            InterviewStatus b = GetInterviewStatusById(id);
            db.InterviewStatuses.Remove(b);
            return db.SaveChanges();
        }


        public InterviewStatus GetInterviewStatusById(int id)
        {
            InterviewStatus c = db.InterviewStatuses.Find(id);
            return c;
        }
    }
}
