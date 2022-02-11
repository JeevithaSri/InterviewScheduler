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
    public class CandidateController : Controller
    {

        public async Task<ActionResult> ViewCandidate(Candidate d, int? page)
        {
            List<Candidate> candidate = new List<Candidate>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllCandidatesUrl );
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                candidate = JsonConvert.DeserializeObject<List<Candidate>>(SubsResponse);
            }
            return View(candidate.ToPagedList(page ?? 1, 5));
        }



        [HttpGet]
        public async Task<ActionResult> AddCandidate()
        {
            List<SelectListItem> DropDownList1 = new List<SelectListItem>();
            List<SelectListItem> DropDownList2 = new List<SelectListItem>();
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
            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllLevelsUrl);
            string apiRes = await res.Content.ReadAsStringAsync();
            LevelSpecializationList = JsonConvert.DeserializeObject<List<InterviewLevel>>(apiRes);
            foreach (var item in LevelSpecializationList)
            {
                DropDownList2.Add(new SelectListItem() { Text = item.Level, Value = item.Id.ToString() });
            }
            ViewBag.specializationLevel = DropDownList2;

            return View();
        }

       

        [HttpPost]
        public async Task<ActionResult> AddCandidate(Candidate d)
        {
            Candidate candidate = new Candidate();
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddCandidateUrl , content);
            if (res.IsSuccessStatusCode)
            {
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            return RedirectToAction("ViewCandidate");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateCandidate(int id)
        {
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateCandidateViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            Candidate candidate = JsonConvert.DeserializeObject<Candidate>(apiResponse);
           
            return View(candidate);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCandidate(Candidate d)
        {
           
            int id = d.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdateCandidateUrl  + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewCandidate");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCandidate(int id)
        {
            TempData["id"] = id;
            Candidate candidate = new Candidate();
         
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.DeleteCandidateViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            candidate = JsonConvert.DeserializeObject<Candidate>(apiResponse);
            return View(candidate);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteCandidate(Candidate d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeleteCandidateUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewCandidate");
        }
    }
}
