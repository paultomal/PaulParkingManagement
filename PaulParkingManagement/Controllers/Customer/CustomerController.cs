using BLL.Services.CustomerServices;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace PaulParkingManagement.Controllers.Customer
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customers")]
        public HttpResponseMessage Customer()
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
        /*[HttpPost]
        [Route("api/customers/add")]
        public HttpResponseMessage InsertCustomer(Customer customer)
        {
            try
            {
                var data = CustomerServices.Insert(customer);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }*/
        [HttpGet]
        [Route("api/customers/delete/{id}")]
        public HttpResponseMessage Customer(string id)
        {
            var res = CustomerServices.DeleteCustomer(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
    }
}
