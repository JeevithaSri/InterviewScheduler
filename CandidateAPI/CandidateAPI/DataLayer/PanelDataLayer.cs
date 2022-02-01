using CandidateAPI.InterviewSchedulerModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateAPI.DataLayer
{
    [CustomExceptionFilter.CustomExceptionFilter]

    public class PanelDataLayer
    {
        private readonly InterviewScheduleContext db = new InterviewScheduleContext();

        public List<Panel> GetAllPanels()
        {
            return db.Panels.ToList();
        }

        public int AddPanel(Panel a)
        {
            db.Panels.Add(a);

            return db.SaveChanges();
        }

        public int UpdatePanel(int id, Panel c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeletePanel(int id)
        {
            Panel b = GetPanelById(id);
            db.Panels.Remove(b);
            return db.SaveChanges();
        }


        public Panel GetPanelById(int id)
        {
            Panel c = db.Panels.Find(id);
            return c;
        }


        public List<PanelAvailability> GetAllPanelAvailabilities()
        {
            return db.PanelAvailabilities.ToList();
        }



        public int AddPanelAvailability(PanelAvailability a)
        {
            db.PanelAvailabilities.Add(a);
            return db.SaveChanges();
        }

        public int UpdatePanelAvailability(int id, PanelAvailability c)
        {
            using (var db = new InterviewScheduleContext())
            {
                db.Entry(c).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public int DeletePanelAvailability(int id)
        {
            PanelAvailability b = GetPanelAvailabilityById(id);
            db.PanelAvailabilities.Remove(b);
            return db.SaveChanges();
        }

        public PanelAvailability GetPanelAvailabilityById(int id)
        {
            PanelAvailability c = db.PanelAvailabilities.Find(id);
            return c;
        }

    }
}
