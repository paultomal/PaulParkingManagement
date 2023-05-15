using BLL.Services.CustomerServices;
using PaulParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace PaulParkingManagement.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel login)
        {
            try
            {
                var res = AuthService.Authenticate(login.Username, login.Password);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User Not Found" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "User not found" });
            }
            /*catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }*/
        }
    }
}
