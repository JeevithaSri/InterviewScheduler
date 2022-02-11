using CandidateAPI.InterviewSchedulerModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InterviewScheduler.Constant
{
    public class Constant
    {
        public static string Baseurl = "https://localhost:44308/";
        public static string JobUrl = "https://localhost:44308/api/Job/";
        public static string CandidateUrl = "https://localhost:44308/api/Candidate/";
        public static string PanelUrl = "https://localhost:44308/api/Panel/";
        public static string ScheduleUrl = "https://localhost:44308/api/Schedule/";
        public static string UsersUrl = "https://localhost:44308/api/Users/";

        public static string GetAllJobsUrl = "https://localhost:44308/api/Job/GetAllJobs";
        public static string AddJobUrl = "https://localhost:44308/api/Job/AddJob";
        public static string UpdateJobViewUrl = "https://localhost:44308/api/Job/GetJobById/";
        public static string UpdateJobUrl = "https://localhost:44308/api/Job/UpdateJob?id=";
        public static string DeleteJobViewUrl = "https://localhost:44308/api/Job/GetJobById/";
        public static string DeleteJobUrl = "https://localhost:44308/api/Job/DeleteJob?id=";
        
        public static string GetJobIdUrl = "https://localhost:44308/api/Job/Jobid/";


    public static string GetAllLevelsUrl = "https://localhost:44308/api/Job/GetAllInterviewLevels";
        public static string AddLevelUrl = "https://localhost:44308/api/Job/AddInterviewLevel";
        public static string UpdateLevelViewUrl = "https://localhost:44308/api/Job/GetInterviewLevelById/";
        public static string UpdateLevelUrl = "https://localhost:44308/api/Job/UpdateInterviewLevel?id=";
        public static string DeleteLevelViewUrl = "https://localhost:44308/api/Job/GetInterviewLevelById";
        public static string DeleteLevelUrl = "https://localhost:44308/api/Job/DeleteInterviewLevel?id=";

        public static string GetAllCandidatesUrl = "https://localhost:44308/api/Candidate/GetAllCandidates";
        public static string AddCandidateUrl = "https://localhost:44308/api/Candidate/AddCandidate";
        public static string UpdateCandidateViewUrl = "https://localhost:44308/api/Candidate/GetCandidateById/";
        public static string UpdateCandidateUrl = "https://localhost:44308/api/Candidate/UpdateCandidate?id=";
        public static string DeleteCandidateViewUrl = "https://localhost:44308/api/Candidate/GetCandidateById/";
        public static string DeleteCandidateUrl = "https://localhost:44308/api/Candidate/DeleteCandidate?id=";

        public static string GetAllCandidateAvailabilitiesUrl = "https://localhost:44308/api/Candidate/GetAllCandidateAvailabilities";
        public static string AddCandidateAvailabilityUrl = "https://localhost:44308/api/Candidate/AddCandidateAvailability";
        public static string UpdateCandidateAvailabilityViewUrl = "https://localhost:44308/api/Candidate/GetCandidateAvailabilityById/";
        public static string UpdateCandidateAvailabilityUrl = "https://localhost:44308/api/Candidate/UpdateCandidateAvailability?id=";
        public static string DeleteCandidateAvailabilityViewUrl = "https://localhost:44308/api/Candidate/GetCandidateAvailabilityById/";
        public static string DeleteCandidateAvailabilityUrl = "https://localhost:44308/api/Candidate/DeleteCandidateAvailability?id=";

        public static string GetAllPanelsUrl = "https://localhost:44308/api/Panel/GetAllPanels";
        public static string AddPanelUrl = "https://localhost:44308/api/Panel/AddPanel";
        public static string UpdatePanelViewUrl = "https://localhost:44308/api/Panel/GetPanelById?id=";
        public static string UpdatePanelUrl = "https://localhost:44308/api/Panel/UpdatePanel?id=";
        public static string DeletePanelViewUrl = "https://localhost:44308/api/Panel/GetPanelById";
        public static string DeletePanelUrl = "https://localhost:44308/api/Panel/DeletePanel?id=";

        public static string GetAllPanelAvailabilitiesUrl = "https://localhost:44308/api/Panel/GetAllPanelAvailabilities";
        public static string AddPanelAvailabilityUrl = "https://localhost:44308/api/Panel/AddPanelAvailability";
        public static string UpdatePanelAvailabilityViewUrl = "https://localhost:44308/api/Panel/GetPanelAvailabilityById/";
        public static string UpdatePanelAvailabilityUrl = "https://localhost:44308/api/Panel/UpdatePanelAvailability?id=";
        public static string DeletePanelAvailabilityViewUrl = "https://localhost:44308/api/Panel/GetPanelAvailabilityById/";
        public static string DeletePanelAvailabilityUrl = "https://localhost:44308/api/Panel/DeletePanelAvailability?id=";

        public static string GetAllSchedulesUrl = "https://localhost:44308/api/Schedule/GetAllSchedules";
        public static string AddScheduleUrl = "https://localhost:44308/api/Schedule/AddSchedule";
        public static string UpdateScheduleViewUrl = "https://localhost:44308/api/Schedule/GetScheduleById";
        public static string UpdateScheduleUrl = "https://localhost:44308/api/Schedule/UpdateSchedule?id=";
        public static string DeleteScheduleViewUrl = "https://localhost:44308/api/Schedule/GetScheduleById";
        public static string DeleteScheduleUrl = "https://localhost:44308/api/Schedule/DeleteSchedule?id=";

        public static string GetAllInterviewStatusesUrl = "https://localhost:44308/api/Schedule/GetAllInterviewStatuses";
        public static string AddInterviewStatusUrl = "https://localhost:44308/api/Schedule/AddInterviewStatus";
        public static string UpdateInterviewStatusViewUrl = "https://localhost:44308/api/Schedule/GetInterviewStatusById/";
        public static string UpdateInterviewStatusUrl = "https://localhost:44308/api/Schedule/UpdateInterviewStatus?id=";
        public static string DeleteInterviewStatusViewUrl = "https://localhost:44308/api/Schedule/GetInterviewStatusById/";
        public static string DeleteInterviewStatusUrl = "https://localhost:44308/api/Schedule/DeleteInterviewStatus?id=";

        public static string AddUserUrl = "https://localhost:44308/api/Users/AddUser";
        public static string LoginUserUrl = "https://localhost:44308/api/Users/LoginUser";
        public static string UsernameUrl = "https://localhost:44308/api/Users/Username/";
        public static string UserPasswordUrl = "https://localhost:44308/api/Users/Password/";

        public static async Task<HttpResponseMessage> GetCall(string endUrl)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync(endUrl);
                return Res;
            }
        }

        public static async Task<HttpResponseMessage> PostCall(string endUrl, StringContent content)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.PostAsync(endUrl, content);
                return response;
            }
        }

        public static async Task<HttpResponseMessage> PutCall(string endUrl, StringContent content)
        {
            using (var httpClient = new HttpClient())
            {
                
                HttpResponseMessage response = await httpClient.PutAsync(endUrl, content);
                return response;
            }
        }

        public static async Task<HttpResponseMessage> DeleteCall(string endUrl)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(endUrl);
                return response;
            }
        }



    }
}
