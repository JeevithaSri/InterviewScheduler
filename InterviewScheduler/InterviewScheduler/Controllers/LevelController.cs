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
    public class LevelController : Controller
    {
        string Baseurl = "https://localhost:44308/";

        public async Task<ActionResult> ViewLevel(InterviewLevel d)
        {
            List<InterviewLevel> level = new List<InterviewLevel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Job/GetAllInterviewLevels");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    level = JsonConvert.DeserializeObject<List<InterviewLevel>>(SubsResponse);

                }
                return View(level);
            }
        }



        [HttpGet]
        public IActionResult AddLevel()
        {


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddLevel(InterviewLevel d)
        {
            InterviewLevel level = new InterviewLevel();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44308/api/Job/AddInterviewLevel", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    level = JsonConvert.DeserializeObject<InterviewLevel>(apiResponse);
                }
            }
            return RedirectToAction("ViewLevel");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateLevel(int id)
        {
            InterviewLevel level = new InterviewLevel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Job/UpdateInterviewLevel" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    level = JsonConvert.DeserializeObject<InterviewLevel>(apiResponse);
                }
            }
            return View(level);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateLevel(InterviewLevel l)
        {
            InterviewLevel level = new InterviewLevel();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = l.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(l), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44308/api/Job/UpdateInterviewLevel?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                }
            }
            return RedirectToAction("ViewLevel");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteLevel(int id)
        {
            TempData["id"] = id;
            InterviewLevel level = new InterviewLevel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Job/DeleteInterviewLevel" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    level = JsonConvert.DeserializeObject<InterviewLevel>(apiResponse);
                }
            }
            return View(level);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteLevel(InterviewLevel d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44308/api/Job/DeleteInterviewLevel?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewInterviewLevel");
        }
    }
}
