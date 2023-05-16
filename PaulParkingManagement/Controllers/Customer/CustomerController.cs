using BLL.DTOs.CustomerDTOs;
using BLL.Services.CustomerServices;
using PaulParkingManagement.Auth;
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
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customers")]
        public HttpResponseMessage Customers()
        {
            try
            {
                var data = CustomerServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        //[Logged]
        [HttpGet]
        [Route("api/customers/{id}")]
        public HttpResponseMessage Customer(string id)
        {
            try
            {
                var data = CustomerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
       [HttpPost]
        [Route("api/customers/add")]
        public HttpResponseMessage InsertCustomer(CustomerDTO cus)
        {
            try
            {
                // var data = CustomerServices.Insert(customer);
                var data = CustomerServices.Insert(cus);
               return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/customers/update")]
        public HttpResponseMessage Update(CustomerDTO cus)
        {
            try
            {
                var data = CustomerServices.Update(cus);
               
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/customers/delete/{id}")]
        public HttpResponseMessage CustomerDelete (string id)
        {
            var res = CustomerServices.DeleteCustomer(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
    }
}
