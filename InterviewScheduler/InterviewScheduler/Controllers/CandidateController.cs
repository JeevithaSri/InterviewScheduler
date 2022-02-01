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
    public class CandidateController : Controller
    {
        string Baseurl = "https://localhost:44308/";

        public async Task<ActionResult> ViewCandidate(Candidate d)
        {
            List<Candidate> candidate = new List<Candidate>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Candidate/GetAllCandidates");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    candidate = JsonConvert.DeserializeObject<List<Candidate>>(SubsResponse);

                }
                return View(candidate);
            }
        }



        [HttpGet]
        public IActionResult AddCandidate()
        {


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCandidate(Candidate d)
        {
            Candidate candidate = new Candidate();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44340/api/Candidate/AddCandidate", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidate = JsonConvert.DeserializeObject<Candidate>(apiResponse);
                }
            }
            return RedirectToAction("ViewCandidate");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateCandidate(int id)
        {
            Candidate candidate = new Candidate();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Candidate/UpdateCandidate" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidate = JsonConvert.DeserializeObject<Candidate>(apiResponse);
                }
            }
            return View(candidate);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCandidate(Candidate d)
        {
            Candidate receivedemp = new Candidate();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = d.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44340/api/Candidate/UpdateCandidate?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    
                }
            }
            return RedirectToAction("ViewCandidate");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCandidate(int id)
        {
            TempData["id"] = id;
            Candidate d = new Candidate();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Candidate/DeleteCandidate" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    d = JsonConvert.DeserializeObject<Candidate>(apiResponse);
                }
            }
            return View(d);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteCandidate(Candidate d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44340/api/Candidate/DeleteCandidate?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewCandidate");
        }
    }
}
