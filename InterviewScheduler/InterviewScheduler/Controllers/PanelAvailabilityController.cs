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
    public class PanelAvailabilityController : Controller
    {

        public async Task<ActionResult> ViewPanelAvailability(PanelAvailability d, int? page)
        {
            List<PanelAvailability> panelavailability = new List<PanelAvailability>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllPanelAvailabilitiesUrl );
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                panelavailability = JsonConvert.DeserializeObject<List<PanelAvailability>>(SubsResponse);
            }
            return View(panelavailability.ToPagedList(page ?? 1, 5));
        }



        [HttpGet]
        public async Task<ActionResult> AddPanelAvailability()
        {
            List<SelectListItem> DropDownList = new List<SelectListItem>();
            List<Panel> SpecializationList = new List<Panel>();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.GetAllPanelsUrl );
            string apiResponse = await response.Content.ReadAsStringAsync();
            SpecializationList = JsonConvert.DeserializeObject<List<Panel>>(apiResponse);
            foreach (var item in SpecializationList)
            {
                DropDownList.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.specializationPanel = DropDownList;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddPanelAvailability(PanelAvailability d)
        {
            PanelAvailability panelavailability = new PanelAvailability();
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddPanelAvailabilityUrl , content);
            if (res.IsSuccessStatusCode)
            {
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            return RedirectToAction("ViewPanelAvailability");
        }

        [HttpGet]
        public async Task<ActionResult> UpdatePanelAvailability(int id)
        {
            PanelAvailability panelavailability = new PanelAvailability();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdatePanelAvailabilityViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            panelavailability = JsonConvert.DeserializeObject<PanelAvailability>(apiResponse);
            return View(panelavailability);
        }

        [HttpPost]
        public async Task<ActionResult> UpdatePanelAvailability(PanelAvailability p)
        {
            PanelAvailability candidate = new PanelAvailability();

            int id = p.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdatePanelAvailabilityUrl  + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewPanelAvailability");
        }

        [HttpGet]
        public async Task<ActionResult> DeletePanelAvailability(int id)
        {
            TempData["id"] = id;
            PanelAvailability panelAvailability = new PanelAvailability();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.DeletePanelAvailabilityViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            panelAvailability = JsonConvert.DeserializeObject<PanelAvailability>(apiResponse);
            return View(panelAvailability);
        }


        [HttpPost]
        public async Task<ActionResult> DeletePanelAvailability(PanelAvailability d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeletePanelAvailabilityUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";


            return RedirectToAction("ViewPanelAvailability");
        }
    }
}
