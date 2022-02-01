//using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Filters;


namespace CandidateAPI.CustomExceptionFilter
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            string errMsg = string.Empty;

            var exceptionType = actionExecutedContext.Exception.GetType();
            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                errMsg = "Unauthorized Access!";
                statusCode = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(NullReferenceException))
            {
                errMsg = "Data is not found!";
                statusCode = HttpStatusCode.NotFound;
            }
            
            else
            {
                errMsg = "Internal Server Error!";
                statusCode = HttpStatusCode.InternalServerError;
            }

            var response = new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(errMsg),
                ReasonPhrase = "From Exception Filter"
            };

            actionExecutedContext.Response = response;
            base.OnException(actionExecutedContext);
        }

    }
}
