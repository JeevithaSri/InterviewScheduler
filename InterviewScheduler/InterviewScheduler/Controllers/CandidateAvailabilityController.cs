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
    public class CandidateAvailabilityController : Controller
    {
        string Baseurl = "https://localhost:44308/";

        public async Task<ActionResult> ViewCandidateAvailability(CandidateAvailability d)
        {
            List<CandidateAvailability> candidate = new List<CandidateAvailability>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Candidate/GetAllCandidateAvailabilities");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    candidate = JsonConvert.DeserializeObject<List<CandidateAvailability>>(SubsResponse);

                }
                return View(candidate);
            }
        }



        [HttpGet]
        public IActionResult AddCandidateAvailability()
        {


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCandidateAvailability(CandidateAvailability d)
        {
            CandidateAvailability candidate = new CandidateAvailability();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44340/api/Candidate/AddCandidateAvailability", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidate = JsonConvert.DeserializeObject<CandidateAvailability>(apiResponse);
                }
            }
            return RedirectToAction("ViewCandidateAvailability");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateCandidateAvailability(int id)
        {
            CandidateAvailability candidate = new CandidateAvailability();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Candidate/UpdateCandidateAvailability" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidate = JsonConvert.DeserializeObject<CandidateAvailability>(apiResponse);
                }
            }
            return View(candidate);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCandidateAvailability(CandidateAvailability c)
        {
            CandidateAvailability candidate = new CandidateAvailability();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = c.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44340/api/Candidate/UpdateCandidateAvailability?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";

                }
            }
            return RedirectToAction("ViewCandidateAvailability");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCandidateAvailability(int id)
        {
            TempData["id"] = id;
            CandidateAvailability d = new CandidateAvailability();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Candidate/DeleteCandidateAvailability" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    d = JsonConvert.DeserializeObject<CandidateAvailability>(apiResponse);
                }
            }
            return View(d);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteCandidateAvailability(CandidateAvailability d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44340/api/Candidate/DeleteCandidateAvailability?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewCandidateAvailability");
        }
    }
}
