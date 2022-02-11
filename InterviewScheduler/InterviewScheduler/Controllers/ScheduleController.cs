using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc.Core;


namespace InterviewScheduler.Controllers
{
    public class ScheduleController : Controller
    {

        public async Task<ActionResult> ViewSchedule(Schedule d, int? page)
        {
            List<Schedule> schedule = new List<Schedule>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllSchedulesUrl );
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                schedule = JsonConvert.DeserializeObject<List<Schedule>>(SubsResponse);
            }
            return View(schedule.ToPagedList(page ?? 1, 5));
        }



        [HttpGet]
        public async Task<ActionResult> AddSchedule()
        {
            List<SelectListItem> DropDownList1 = new List<SelectListItem>();
            List<SelectListItem> DropDownList2 = new List<SelectListItem>();
            List<SelectListItem> DropDownList3 = new List<SelectListItem>();
            List<SelectListItem> DropDownList4 = new List<SelectListItem>();

            List<Job> JobSpecializationList = new List<Job>();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.GetAllJobsUrl);
            string apiResponse = await response.Content.ReadAsStringAsync();
            JobSpecializationList = JsonConvert.DeserializeObject<List<Job>>(apiResponse);
            foreach (var item in JobSpecializationList)
            {
                DropDownList1.Add(new SelectListItem() { Text = item.JobRole, Value = item.Id.ToString() });
            }
            ViewBag.specializationJob = DropDownList1;

            List<InterviewLevel> LevelSpecializationList = new List<InterviewLevel>();
            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.JobUrl + "GetAllInterviewLevels");
            string apiRes = await res.Content.ReadAsStringAsync();
            LevelSpecializationList = JsonConvert.DeserializeObject<List<InterviewLevel>>(apiRes);
            foreach (var item in LevelSpecializationList)
            {
                DropDownList2.Add(new SelectListItem() { Text = item.Level, Value = item.Id.ToString() });
            }
            ViewBag.specializationLevel = DropDownList2;

            List<Candidate> CandidateSpecializationList = new List<Candidate>();
            HttpResponseMessage resp = await Constant.Constant.GetCall(Constant.Constant.GetAllCandidatesUrl);
            string apiResp = await resp.Content.ReadAsStringAsync();
            CandidateSpecializationList = JsonConvert.DeserializeObject<List<Candidate>>(apiResp);
            foreach (var item in CandidateSpecializationList)
            {
                DropDownList3.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.specializationCandidate = DropDownList3;

            List<Panel> PanelSpecializationList = new List<Panel>();
            HttpResponseMessage Resp = await Constant.Constant.GetCall(Constant.Constant.GetAllPanelsUrl);
            string ApiResp = await Resp.Content.ReadAsStringAsync();
            PanelSpecializationList = JsonConvert.DeserializeObject<List<Panel>>(ApiResp);
            foreach (var item in PanelSpecializationList)
            {
                DropDownList4.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.specializationPanel = DropDownList4;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddSchedule(Schedule d)
        {
            Schedule schedule = new Schedule();
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddScheduleUrl , content);
            if (res.IsSuccessStatusCode)
            {
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            return RedirectToAction("ViewSchedule");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateSchedule(int id)
        {
            Schedule schedule = new Schedule();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateScheduleViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            schedule = JsonConvert.DeserializeObject<Schedule>(apiResponse);
            return View(schedule);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateSchedule(Schedule d)
        {
            Schedule schedule = new Schedule();

            int id = d.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdateScheduleUrl  + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewSchedule");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteSchedule(int id)
        {
            TempData["id"] = id;
            Schedule schedule = new Schedule();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.DeleteScheduleViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            schedule = JsonConvert.DeserializeObject<Schedule>(apiResponse);
            return View(schedule);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteSchedule(Schedule d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeleteScheduleUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewSchedule");
        }
    }
}
