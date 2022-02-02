using BookStore.Model;
using BookStore.Repositroy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks() {
            var data  = bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id) {
            return bookRepository.GetBookById(1);
        } 
        public List<BookModel> SearchBook(string bookName, string authorNAme)
        {
            return bookRepository.SearchBook(bookName, authorNAme);
        }
    }
    
}
