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

namespace InterviewScheduler.Controllers
{
    public class PanelController : Controller
    {
        string Baseurl = "https://localhost:44308/";

        public async Task<ActionResult> ViewPanel(Panel d)
        {
            List<Panel> panel = new List<Panel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Panel/GetAllPanels");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    panel = JsonConvert.DeserializeObject<List<Panel>>(SubsResponse);

                }
                return View(panel);
            }
        }



        [HttpGet]
        public IActionResult AddPanel()
        {


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddPanel(Panel d)
        {
            Panel panel = new Panel();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44308/api/Panel/AddPanel", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    panel = JsonConvert.DeserializeObject<Panel>(apiResponse);
                }
            }
            return RedirectToAction("ViewPanel");
        }

        [HttpGet]
        public async Task<ActionResult> UpdatePanel(int id)
        {
            Panel panel = new Panel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Job/UpdateJob" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    panel = JsonConvert.DeserializeObject<Panel>(apiResponse);
                }
            }
            return View(panel);
        }

        [HttpPost]
        public async Task<ActionResult> UpdatePanel(Panel p)
        {
            Panel job = new Panel();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = p.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44308/api/Panel/UpdatePanel?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                }
            }
            return RedirectToAction("ViewPanel");
        }

        [HttpGet]
        public async Task<ActionResult> DeletePanel(int id)
        {
            TempData["id"] = id;
            Panel p = new Panel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Panel/DeletePanel" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p = JsonConvert.DeserializeObject<Panel>(apiResponse);
                }
            }
            return View(p);
        }


        [HttpPost]
        public async Task<ActionResult> DeletePanel(Panel p)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44308/api/Panel/DeletePanel?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewPanel");
        }
    }
}
