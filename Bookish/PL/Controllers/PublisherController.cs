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
    public class PublisherController : ApiController
    {
        [HttpGet]
        [Route("api/publishers/get")]
        public HttpResponseMessage PublisherGet()
        {
            try
            {
                var data = PublisherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/publishers/get/{id}")]
        public HttpResponseMessage PublisherGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PublisherService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/publishers/add")]
        public HttpResponseMessage AddPublisher(PublisherDTO publisherDTO)
        {
            try
            {
                PublisherService.Create(publisherDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/publishers/update")]
        public HttpResponseMessage UpdatePublisher(PublisherDTO publisherDTO)
        {
            try
            {
                PublisherService.Update(publisherDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/publishers/delete/{id}")]
        public HttpResponseMessage PublisherDelete(int id)
        {
            try
            {
                PublisherService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


    }
}
