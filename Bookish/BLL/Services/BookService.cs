using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookService
    {
        //obj is null in update when use auto mapper (get work correctly)

        //public static List<BookDTO> Get()
        //{
        //    var data = DataAccessFactory.BookData().Read();
        //    var cfg = new MapperConfiguration(c =>
        //    {
        //        c.CreateMap<Book, BookDTO>();
        //    });
        //    var mapper = new Mapper(cfg);
        //    var mapped = mapper.Map<List<BookDTO>>(data);
        //    return mapped;
        //}
        //public static List<BookDTO> Get(int id)
        //{
        //    var data = DataAccessFactory.BookData().Read(id);
        //    var cfg = new MapperConfiguration(c =>
        //    {
        //        c.CreateMap<Book, BookDTO>();
        //    });
        //    var mapper = new Mapper(cfg);
        //    var mapped = mapper.Map<List<BookDTO>>(data);
        //    return mapped;
        //}
        //public static void Add(BookDTO book)
        //{
        //    var cfg = new MapperConfiguration(c =>
        //    {
        //        c.CreateMap<BookDTO, Book>();
        //    });
        //    var mapper = new Mapper(cfg);
        //    var newBook = mapper.Map<Book>(book);
        //    DataAccessFactory.BookData().Create(newBook);
        //}
        //public static void Update(BookDTO book)
        //{
        //    var cfg = new MapperConfiguration(c =>
        //    {
        //        c.CreateMap<BookDTO, Book>()
        //            .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore the Id property since it should not be updated.
        //    });
        //    var mapper = new Mapper(cfg);
        //    var updatedBook = mapper.Map<Book>(book);
        //    DataAccessFactory.BookData().Update(updatedBook);
        //}
        //public static bool Delete(int id)
        //{
        //    var res = DataAccessFactory.BookData().Delete(id);
        //    return res;
        //}

        public static List<BookDTO> Get()
        {
            var data = DataAccessFactory.BookData().Read();
            return Convert(data);
        }
        public static BookDTO Get(int id)
        {
            return Convert(DataAccessFactory.BookData().Read(id));
        }
        public static bool Create(BookDTO bookDTO)
        {
            var data = Convert(bookDTO);
            var res = DataAccessFactory.BookData().Create(data);
            if (res != null) return true;
            return false;
        }
        public static bool Update(BookDTO bookDTO)
        {
            var data = Convert(bookDTO);
            var res = DataAccessFactory.BookData().Update(data);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.BookData().Delete(id);
        }
        static List<BookDTO> Convert(List<Book> books) //convert object to DTO and object
        {
            var data = new List<BookDTO>();
            foreach (var book in books)
            {
                data.Add(Convert(book));
            }
            return data;
        }
        static Book Convert(BookDTO bookDTO) //return from database
        {
            return new Book()
            {
                Id = bookDTO.Id,
                Title = bookDTO.Title,
                Price = bookDTO.Price,
                Quantity = bookDTO.Quantity,
                PublisherId = bookDTO.PublisherId
            };
        }
        static BookDTO Convert(Book book)
        {
            return new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                Price = book.Price,
                Quantity = book.Quantity,
                PublisherId = book.PublisherId
            };
        }
    }
}