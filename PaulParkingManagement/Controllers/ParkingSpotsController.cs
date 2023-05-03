using BLL.Services.ServiceProviderServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaulParkingManagement.Controllers
{
    public class ParkingSpotsController : ApiController
    {
        [HttpGet]
        [Route("api/parkingspots")]
        public HttpResponseMessage ParkingSpot()
        {
            try
            {
                var data = ParkingSpotsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception sp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = sp.Message });
            }
        }
        [HttpGet]
        [Route("api/parkingspots/{id}")]
        public HttpResponseMessage ParkingSpot(string id)
        {
            try
            {
                var data = ParkingSpotsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception sp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = sp.Message });
            }
        }
        //Reviews
        [HttpGet]
        [Route("api/posts/{id}/reviews")]
        public HttpResponseMessage SpotReviews(string id)
        {
            try
            {
                var data = ParkingSpotsService.GetwithReviews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception sp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = sp.Message });
            }
        }
        //Reservations
        [HttpGet]
        [Route("api/posts/{id}/reservations")]
        public HttpResponseMessage SpotReservation(string id)
        {
            try
            {
                var data = ParkingSpotsService.GetwithPayments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception sp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = sp.Message });
            }
        }
        //Payments
        [HttpGet]
        [Route("api/posts/{id}/payments")]
        public HttpResponseMessage SpotPayment(string id)
        {
            try
            {
                var data = ParkingSpotsService.GetwithPayments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception sp)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = sp.Message });
            }
        }
    }
}
