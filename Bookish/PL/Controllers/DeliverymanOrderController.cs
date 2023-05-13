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
    public class DeliverymanOrderController : ApiController
    {
        [HttpGet]
        [Route("api/deliverymanOrders/get")]
        public HttpResponseMessage DeliverymanOrderGet()
        {
            try
            {
                var data = DeliverymanOrderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/deliverymanOrders/get/{id}")]
        public HttpResponseMessage DeliverymanOrderGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, DeliverymanOrderService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/deliverymanOrders/add")]
        public HttpResponseMessage AddDeliverymanOrder(DeliverymanOrderDTO deliverymanOrderDTO)
        {
            try
            {
                DeliverymanOrderService.Create(deliverymanOrderDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/deliverymanOrders/update")]
        public HttpResponseMessage UpdateDeliverymanOrder(DeliverymanOrderDTO deliverymanOrderDTO)
        {
            try
            {
                DeliverymanOrderService.Update(deliverymanOrderDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/deliverymanOrders/delete/{id}")]
        public HttpResponseMessage DeliverymanOrderDelete(int id)
        {
            try
            {
                DeliverymanOrderService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
