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
    public class CartController : ApiController
    {
        [HttpGet]
        [Route("api/carts/get")]
        public HttpResponseMessage CartGet()
        {
            try
            {
                var data = CartService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/carts/get/{id}")]
        public HttpResponseMessage CartGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CartService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/carts/add")]
        public HttpResponseMessage AddCart(CartDTO cartDTO)
        {
            try
            {
                CartService.Create(cartDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/carts/update")]
        public HttpResponseMessage UpdateCart(CartDTO cartDTO)
        {
            try
            {
                CartService.Update(cartDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/carts/delete/{id}")]
        public HttpResponseMessage CartDelete(int id)
        {
            try
            {
                CartService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}
