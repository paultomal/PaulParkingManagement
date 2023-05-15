using BLL.DTOs.CustomerDTOs;
using BLL.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaulParkingManagement.Controllers.Customer
{
    public class ReviewController : ApiController
    {
        [HttpGet]
        [Route("api/reviews")]
        public HttpResponseMessage Review()
        {
            try
            {
                var data = ReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reviews/add")]
        public HttpResponseMessage InsertReviews(ReviewDTO cus)
        {
            try
            {
                var data = ReviewService.Insert(cus);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/reviews/update")]
        public HttpResponseMessage Update(ReviewDTO cus)
        {
            try
            {
                var data = ReviewService.Update(cus);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Massage = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/reviews/delete/{id}")]
        public HttpResponseMessage ReviewDelete(string id)
        {
            var res = ReviewService.DeleteReview(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
    }
}
