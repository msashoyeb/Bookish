using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PL.Controllers
{
    [EnableCors("*", "*", "*")]
    public class RatingController : ApiController
    {
        [HttpGet]
        [Route("api/ratings/get")]
        public HttpResponseMessage RatingGet()
        {
            try
            {
                var data = RatingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/ratings/get/{id}")]
        public HttpResponseMessage RatingGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RatingService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/ratings/add")]
        public HttpResponseMessage AddRating(RatingDTO ratingDTO)
        {
            try
            {
                RatingService.Create(ratingDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/ratings/update")]
        public HttpResponseMessage UpdateRating(RatingDTO ratingDTO)
        {
            try
            {
                RatingService.Update(ratingDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/ratings/delete/{id}")]
        public HttpResponseMessage RatingDelete(int id)
        {
            try
            {
                RatingService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


    }
}

