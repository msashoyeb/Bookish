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
    public class ComplaintController : ApiController
    {
        [HttpGet]
        [Route("api/complaints/get")]
        public HttpResponseMessage ComplaintGet()
        {
            try
            {
                var data = ComplaintService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/complaints/get/{id}")]
        public HttpResponseMessage ComplaintGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ComplaintService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/complaints/add")]
        public HttpResponseMessage AddComplaint(ComplaintDTO complaintDTO)
        {
            try
            {
                ComplaintService.Create(complaintDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/complaints/update")]
        public HttpResponseMessage UpdateComplaint(ComplaintDTO complaintDTO)
        {
            try
            {
                ComplaintService.Update(complaintDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/complaints/delete/{id}")]
        public HttpResponseMessage ComplaintDelete(int id)
        {
            try
            {
                ComplaintService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

