using CandidateAPI.InterviewSchedulerModel;
//using InterviewScheduler.InterviewSchedulerModel;
using Microsoft.AspNetCore.Http;
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
    public class LoginController : Controller
    {
       private readonly ISession session;
        string Baseurl = "https://localhost:44308/";



        public static List<User> user = new List<User>();


        public LoginController(IHttpContextAccessor httpContextAccessor)
        {
            session = httpContextAccessor.HttpContext.Session;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SaveUser(Register user)
        {
            using (var client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                HttpResponseMessage Res = await client.PostAsync("https://localhost:44308/api/Users/AddUser", content);
                
                if (Res.IsSuccessStatusCode)
                {
                    
                    return RedirectToAction("Login", "Login");

                }
                return Content("error");
            }
        }


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Login(User user, string Message)
        {
            User userObj = new User();

            using (var client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                HttpResponseMessage Res = await client.PostAsync("https://localhost:44308/api/Users/LoginUser", content);

              
                    if (Res.IsSuccessStatusCode)
                    {
                        string apiResponse = await Res.Content.ReadAsStringAsync();
                        userObj = JsonConvert.DeserializeObject<User>(apiResponse);


                        if (userObj != null)
                        {

                            if (userObj.RoleId == 1)
                            {
                                return RedirectToAction("Index", "HrDashboard");
                            }
                            else if (userObj.RoleId == 2)
                            {
                                return RedirectToAction("Index", "RecruitorDashboard");
                            }

                        }
                    }

               

                ViewBag.Message = string.Format("Your Username or Password is incorrect", Message);
                return View(Message);
               

            }   
        }


            public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        public async Task<bool> IsUserNameExist(string Username)
        {
            
            Register validateName = new Register();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44308/api/Users/Username/" + Username))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    validateName = JsonConvert.DeserializeObject<Register>(apiResponse);
                }

            }
            if (validateName.Username != null)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

    }
}
