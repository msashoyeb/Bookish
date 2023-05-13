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
    public class DeliverymanController : ApiController
    {
        [HttpGet]
        [Route("api/deliverymans/get")]
        public HttpResponseMessage DeliverymanGet()
        {
            try
            {
                var data = DeliverymanService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/deliverymans/get/{id}")]
        public HttpResponseMessage DeliverymanGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, DeliverymanService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/deliverymans/add")]
        public HttpResponseMessage AddDeliveryman(DeliverymanDTO deliverymanDTO)
        {
            try
            {
                DeliverymanService.Create(deliverymanDTO) ;
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/deliverymans/update")]
        public HttpResponseMessage UpdateDeliveryman(DeliverymanDTO deliverymanDTO)
        {
            try
            {
                DeliverymanService.Update(deliverymanDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/deliverymans/delete/{id}")]
        public HttpResponseMessage DeliverymanDelete(int id)
        {
            try
            {
                DeliverymanService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
