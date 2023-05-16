using BLL.DTOs.CustomerDTOs;
using BLL.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PaulParkingManagement.Controllers.Customer
{
    [EnableCors("*", "*", "*")]
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
       [HttpPost]
        [Route("api/reservations/add")]
        public HttpResponseMessage Insert(ReservationDTO cus)
        {
            try
            {
                // var data = CustomerServices.Insert(customer);
                var data = ReservationService.Insert(cus);
               return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reservations/update")]
        public HttpResponseMessage Update(ReservationDTO cus)
        {
            try
            {
                var data = ReservationService.Update(cus);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
