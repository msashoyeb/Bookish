using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services.Description;

namespace PL.Controllers
{
    [EnableCors("*","*","*")]
    public class BookController : ApiController
    {
        [HttpGet]
        [Route("api/books/get")]
        public HttpResponseMessage BookGet()
        {
            try
            {
                var data = BookService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/books/get/{id}")]
        public HttpResponseMessage BookGet(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BookService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/books/add")]
        public HttpResponseMessage AddBook(BookDTO bookDTO)
        {
            try
            {
                BookService.Create(bookDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("api/books/update")]
        public HttpResponseMessage UpdateBook(BookDTO bookDTO)
        {
            try
            {
                BookService.Update(bookDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("api/books/delete/{id}")]
        public HttpResponseMessage BookDelete(int id)
        {
            try
            {
                BookService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}