using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace InterviewScheduler.Controllers
{
    public class InterviewStatusController : Controller
    {
        public async Task<ActionResult> ViewInterviewStatus(InterviewStatus d, int? page)
        {
            List<InterviewStatus> interviewStatus = new List<InterviewStatus>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllInterviewStatusesUrl);
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                interviewStatus = JsonConvert.DeserializeObject<List<InterviewStatus>>(SubsResponse);
            }
            return View(interviewStatus.ToPagedList(page ?? 1, 5));
        }


        [HttpGet]
        public async Task<ActionResult> AddInterviewStatus()
        {
            List<SelectListItem> DropDownList = new List<SelectListItem>();
           
            List<Schedule> ScheduleSpecializationList = new List<Schedule>();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.GetAllSchedulesUrl);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ScheduleSpecializationList = JsonConvert.DeserializeObject<List<Schedule>>(apiResponse);
            foreach (var item in ScheduleSpecializationList)
            {
                DropDownList.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.specializationSchedule = DropDownList;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddInterviewStatus(InterviewStatus d)
        {
            InterviewStatus interviewStatus = new InterviewStatus();
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddInterviewStatusUrl, content);
            if (res.IsSuccessStatusCode)
            {
                string apiResponse = await res.Content.ReadAsStringAsync();
            }

            return RedirectToAction("ViewInterviewStatus");

        }

        [HttpGet]
        public async Task<ActionResult> UpdateInterviewStatus(int id)
        {

            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateInterviewStatusViewUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            InterviewStatus interviewStatus = JsonConvert.DeserializeObject<InterviewStatus>(apiResponse);

            return View(interviewStatus);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateJob(InterviewStatus d)
        {
            InterviewStatus interviewStatus = new InterviewStatus();
            int id = d.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdateJobUrl + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";


            return RedirectToAction("ViewInterviewStatus");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteInterviewStatus(int id)
        {
            TempData["id"] = id;
            InterviewStatus interviewStatus = new InterviewStatus();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateInterviewStatusViewUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            interviewStatus = JsonConvert.DeserializeObject<InterviewStatus>(apiResponse);
            return View(interviewStatus);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteInterviewStatus(InterviewStatus d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeleteInterviewStatusUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewInterviewStatus");
        }
    }
}
