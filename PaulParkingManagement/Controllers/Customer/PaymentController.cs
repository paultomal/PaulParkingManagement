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
    public class PaymentController : ApiController
    {
        [HttpGet]
        [Route("api/payments")]
        public HttpResponseMessage Payment()
        {
            try
            {
                var data = PaymentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/payments/add")]
        public HttpResponseMessage AddPayment(PaymentDTO pay)
        {
            try
            {
                var data = PaymentService.Insert(pay);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/payments/update")]
        public HttpResponseMessage UpdatePayment(PaymentDTO pay)
        {
            try
            {
                var data = PaymentService.Update(pay);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
    }
}
