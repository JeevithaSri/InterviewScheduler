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
    public class ScheduleController : Controller
    {
        string Baseurl = "https://localhost:44308/";

        public async Task<ActionResult> ViewSchedule(Schedule d)
        {
            List<Schedule> schedule = new List<Schedule>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Job/GetAllSchedules");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    schedule = JsonConvert.DeserializeObject<List<Schedule>>(SubsResponse);

                }
                return View(schedule);
            }
        }



        [HttpGet]
        public IActionResult AddSchedule()
        {


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddSchedule(Schedule d)
        {
            Schedule schedule = new Schedule();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44308/api/Schedule/AddSchedule", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    schedule = JsonConvert.DeserializeObject<Schedule>(apiResponse);
                }
            }
            return RedirectToAction("ViewSchedule");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateSchedule(int id)
        {
            Schedule schedule = new Schedule();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Schedule/UpdateSchedule" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    schedule = JsonConvert.DeserializeObject<Schedule>(apiResponse);
                }
            }
            return View(schedule);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateSchedule(Schedule d)
        {
            Schedule schedule = new Schedule();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = d.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44308/api/Schedule/UpdateSchedule?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";

                }
            }
            return RedirectToAction("ViewJob");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteSchedule(int id)
        {
            TempData["id"] = id;
            Schedule s = new Schedule();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Schedule/DeleteSchedule" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    s = JsonConvert.DeserializeObject<Schedule>(apiResponse);
                }
            }
            return View(s);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteSchedule(Schedule d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44308/api/Job/DeleteSchedule?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewSchedule");
        }
    }
}
