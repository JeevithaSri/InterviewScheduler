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
    public class PanelController : Controller
    {

        public async Task<ActionResult> ViewPanel(Panel d, int? page)
        {
            List<Panel> panel = new List<Panel>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllPanelsUrl );
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                panel = JsonConvert.DeserializeObject<List<Panel>>(SubsResponse);
            }
            return View(panel.ToPagedList(page ?? 1, 5));
        }



        [HttpGet]
        public async Task<ActionResult> AddPanel()
        {

            List<SelectListItem> DropDownList1 = new List<SelectListItem>();
            List<SelectListItem> DropDownList2 = new List<SelectListItem>();
            List<Job> JobSpecializationList = new List<Job> ();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.GetAllJobsUrl );
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
        public async Task<ActionResult> AddPanel(Panel d)
        {
            try
            {
                Panel panel = new Panel();


                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
                HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddPanelUrl, content);
                if (res.IsSuccessStatusCode)
                {
                    string apiResponse = await res.Content.ReadAsStringAsync();
                }
                return RedirectToAction("ViewPanel");
            }
            catch(Exception)
            {
                return View("Error", "Shared");
            }
        }

        [HttpGet]
        public async Task<ActionResult> UpdatePanel(int id)
        {
            Panel panel = new Panel();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdatePanelViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            panel = JsonConvert.DeserializeObject<Panel>(apiResponse);
            return View(panel);
        }

        [HttpPost]
        public async Task<ActionResult> UpdatePanel(Panel p)
        {
            Panel job = new Panel();

            int id = p.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdatePanelUrl  + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewPanel");
        }

        [HttpGet]
        public async Task<ActionResult> DeletePanel(int id)
        {
            TempData["id"] = id;
            Panel panel = new Panel();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.DeletePanelViewUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            panel = JsonConvert.DeserializeObject<Panel>(apiResponse);
            return View(panel);
        }


        [HttpPost]
        public async Task<ActionResult> DeletePanel(Panel p)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeletePanelUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewPanel");
        }
    }
}
