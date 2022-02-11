using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using InterviewScheduler.Constant;
using X.PagedList;
using X.PagedList.Mvc.Core;




namespace InterviewScheduler.Controllers
{
    public class JobController : Controller
    {
        public async Task<ActionResult> ViewJob(Job d, int? page)
        {
            List<Job> job = new List<Job>();

            HttpResponseMessage res =await Constant.Constant.GetCall(Constant.Constant.GetAllJobsUrl);
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                job = JsonConvert.DeserializeObject<List<Job>>(SubsResponse);
            }
            return View(job.ToPagedList(page ?? 1, 5));           
        }

       
        [HttpGet]
        public IActionResult AddJob()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddJob(Job d)
        {
            Job job = new Job();
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddJobUrl , content);
            if(res.IsSuccessStatusCode){
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            
            return RedirectToAction("ViewJob");

        }

        [HttpGet]
        public async Task<ActionResult> UpdateJob( int id)
        {

            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateJobViewUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            Job job = JsonConvert.DeserializeObject<Job>(apiResponse);
            
            return View(job);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateJob(Job d)
        {
            Job job = new Job();
            int id = d.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdateJobUrl  + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            
            return RedirectToAction("ViewJob");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteJob(int id)
        {
            TempData["id"] = id;
            Job job = new Job();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateJobViewUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            job = JsonConvert.DeserializeObject<Job>(apiResponse);
            return View(job);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteJob(Job d)
        {
            try
            {
                int id = Convert.ToInt32(TempData["id"]);
                HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeleteJobUrl + id);
                string apiResponse = await response.Content.ReadAsStringAsync();
                ViewBag.Result = "Success";

                return RedirectToAction("ViewJob");
            }catch(Exception)
            {
                return View("Error", "Shared");
            }
           
        }


        public async Task<bool> IsJobIdExist(string Jobid)
        {

            Job validateName = new Job();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Constant.Constant.GetJobIdUrl + Jobid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    validateName = JsonConvert.DeserializeObject<Job>(apiResponse);
                }

            }
            if (validateName.JobId != null)
            {
                return false;
            }
            else
            {
                return true;
            }




        }
    }
}
