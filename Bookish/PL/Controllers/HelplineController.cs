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
    public class HelplineController : ApiController
    {
        [HttpGet]
        [Route("api/helplines/get")]
        public HttpResponseMessage HelplineGet()
        {
            try
            {
                var data = HelplineService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/helplines/get/{id}")]
        public HttpResponseMessage HelplineGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, HelplineService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/helplines/add")]
        public HttpResponseMessage AddHelpline(HelplineDTO helplineDTO)
        {
            try
            {
                HelplineService.Create(helplineDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/helplines/update")]
        public HttpResponseMessage UpdateHelpline(HelplineDTO helplineDTO)
        {
            try
            {
                HelplineService.Update(helplineDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/helplines/delete/{id}")]
        public HttpResponseMessage HelplineDelete(int id)
        {
            try
            {
                HelplineService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
