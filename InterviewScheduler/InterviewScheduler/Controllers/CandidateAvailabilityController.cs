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
    public class CandidateAvailabilityController : Controller
    {
        

        public async Task<ActionResult> ViewCandidateAvailability(CandidateAvailability d, int? page)
        {
            List<CandidateAvailability> candidateavailability = new List<CandidateAvailability>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllCandidateAvailabilitiesUrl );
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                candidateavailability = JsonConvert.DeserializeObject<List<CandidateAvailability>>(SubsResponse);
            }
            return View(candidateavailability.ToPagedList(page ?? 1, 5));
        }



        [HttpGet]
        public async Task<ActionResult> AddCandidateAvailability()
        {

            List<SelectListItem> DropDownList = new List<SelectListItem>();
            List<Candidate> SpecializationList = new List<Candidate>();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.GetAllCandidatesUrl );
            string apiResponse = await response.Content.ReadAsStringAsync();
            SpecializationList = JsonConvert.DeserializeObject<List<Candidate>>(apiResponse);
            foreach (var item in SpecializationList)
            {
                DropDownList.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.specializationCandidate = DropDownList;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCandidateAvailability(CandidateAvailability d)
        {
            CandidateAvailability candidateavailability = new CandidateAvailability();
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddCandidateAvailabilityUrl , content);
            if (res.IsSuccessStatusCode)
            {
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            return RedirectToAction("ViewCandidateAvailability");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateCandidateAvailability(int id)
        {
            CandidateAvailability candidateavailability = new CandidateAvailability();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateCandidateAvailabilityViewUrl + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            candidateavailability = JsonConvert.DeserializeObject<CandidateAvailability>(apiResponse);
            return View(candidateavailability);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCandidateAvailability(CandidateAvailability c)
        {
            //CandidateAvailability candidate = new CandidateAvailability();

            int id = c.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdateCandidateAvailabilityUrl + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewCandidateAvailability");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCandidateAvailability(int id)
        {
            TempData["id"] = id;
            CandidateAvailability candidateAvailability = new CandidateAvailability();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.DeleteCandidateAvailabilityViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            candidateAvailability = JsonConvert.DeserializeObject<CandidateAvailability>(apiResponse);
            return View(candidateAvailability);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteCandidateAvailability(CandidateAvailability d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeleteCandidateAvailabilityUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewCandidateAvailability");
        }
    }
}
