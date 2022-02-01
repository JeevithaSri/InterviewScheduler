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

namespace InterviewScheduler.Controllers
{
    public class JobController : Controller
    {

        string Baseurl = "https://localhost:44308/";

        public async Task<ActionResult> ViewJob(Job d)
        {
            List<Job> job = new List<Job>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Job/GetAllJobs");
                 
                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    job = JsonConvert.DeserializeObject<List<Job>>(SubsResponse);

                }
                return View(job);
            }
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
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44308/api/Job/AddJob", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    job = JsonConvert.DeserializeObject<Job>(apiResponse);
                }
            }
            return RedirectToAction("ViewJob");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateJob(int id)
        {
            Job job = new Job();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Job/UpdateJob" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    job = JsonConvert.DeserializeObject<Job>(apiResponse);
                }
            }
            return View(job);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateJob(Job d)
        {
            Job job = new Job();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = d.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44308/api/Job/UpdateJob?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    
                }
            }
            return RedirectToAction("ViewJob");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteJob(int id)
        {
            TempData["id"] = id;
            Job d = new Job();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Job/DeleteJob" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    d = JsonConvert.DeserializeObject<Job>(apiResponse);
                }
            }
            return View(d);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteJob(Job d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44308/api/Job/DeleteJob?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewJob");
        }
    }
}
