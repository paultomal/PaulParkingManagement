using BLL.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaulParkingManagement.Controllers.Customer
{
    public class ReservationController : ApiController
    {
        [HttpGet]
        [Route("api/reservations")]
        public HttpResponseMessage Reservation()
        {
            try
            {
                var data = ReservationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
