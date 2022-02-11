using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.DataLayer
{
    [CustomExceptionFilter.CustomExceptionFilter]

    public class CandidateDataLayer
    {
        private readonly InterviewScheduleContext db = new InterviewScheduleContext();

        public List<Candidate> GetAllCandidates()
        {
        

            return db.Candidates.Include(t => t.Job)
                            .Include(t => t.Level)
                            .ToList();
        }

        public int AddCandidate(Candidate a)
        {
            db.Candidates.Add(a);
            
            return db.SaveChanges();
        }

        public int UpdateCandidate(int id, Candidate c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteCandidate(int id)
        {
            Candidate b = GetCandidateById(id);
            db.Candidates.Remove(b);
            return db.SaveChanges();
        }

       
        public Candidate GetCandidateById(int id)
        {
            Candidate c = db.Candidates.Find(id);
            return c;
        }




        public List<CandidateAvailability> GetAllCandidateAvailabilities()
        {
            return db.CandidateAvailabilities.Include(t => t.Candidate)
                            
                                             .ToList();
        }



        public int AddCandidateAvailability(CandidateAvailability a)
        {
            
            db.CandidateAvailabilities.Add(a);
            return db.SaveChanges();
        }

        public int UpdateCandidateAvailability(int id, CandidateAvailability c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeleteCandidateAvailability(int id)
        {
            CandidateAvailability b = GetCandidateAvailabilityById(id);
            db.CandidateAvailabilities.Remove(b);
            return db.SaveChanges();
        }

        public CandidateAvailability GetCandidateAvailabilityById(int id)
        {
            CandidateAvailability c = db.CandidateAvailabilities.Find(id);
            return c;
        }

        
        
    }
}
