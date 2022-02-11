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
using X.PagedList;
using X.PagedList.Mvc.Core;


namespace InterviewScheduler.Controllers
{
    public class LevelController : Controller
    {

        public async Task<ActionResult> ViewLevel(InterviewLevel d, int? page)
        {
            List<InterviewLevel> level = new List<InterviewLevel>();

            HttpResponseMessage res = await Constant.Constant.GetCall(Constant.Constant.GetAllLevelsUrl );
            if (res.IsSuccessStatusCode)
            {
                var SubsResponse = res.Content.ReadAsStringAsync().Result;
                level = JsonConvert.DeserializeObject<List<InterviewLevel>>(SubsResponse);
            }
            return View(level.ToPagedList(page ?? 1, 5));
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
            StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Constant.Constant.PostCall(Constant.Constant.AddLevelUrl , content);
            if (res.IsSuccessStatusCode)
            {
                string apiResponse = await res.Content.ReadAsStringAsync();
            }
            return RedirectToAction("ViewLevel");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateLevel(int id)
        {
            InterviewLevel level = new InterviewLevel();
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.UpdateLevelViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            level = JsonConvert.DeserializeObject<InterviewLevel>(apiResponse);
            return View(level);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateLevel(InterviewLevel l)
        {

            int id = l.Id;

            StringContent content = new StringContent(JsonConvert.SerializeObject(l), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Constant.Constant.PutCall(Constant.Constant.UpdateLevelUrl  + id, content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewLevel");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteLevel(int id)
        {
            TempData["id"] = id;
            InterviewLevel level = new InterviewLevel();
          
            HttpResponseMessage response = await Constant.Constant.GetCall(Constant.Constant.DeleteLevelViewUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            level = JsonConvert.DeserializeObject<InterviewLevel>(apiResponse);
            return View(level);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteLevel(InterviewLevel d)
        {
            int id = Convert.ToInt32(TempData["id"]);
            HttpResponseMessage response = await Constant.Constant.DeleteCall(Constant.Constant.DeleteLevelUrl  + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            ViewBag.Result = "Success";

            return RedirectToAction("ViewInterviewLevel");
        }
    }
}
