using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositroy
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks() {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.bookTitle.Contains(title) && x.bookAuthor.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource() {
            return new List<BookModel>() {
               new BookModel(){ Id = 1, bookTitle = "MVC" , bookAuthor = "Zubair"},
               new BookModel(){ Id = 2, bookTitle = "MVC" , bookAuthor = "Zubair"},
               new BookModel(){ Id = 3, bookTitle = "MVC" , bookAuthor = "Zubair"},
               new BookModel(){ Id = 4, bookTitle = "MVC" , bookAuthor = "Zubair"},
               new BookModel(){ Id = 5, bookTitle = "MVC" , bookAuthor = "Zubair"},
               new BookModel(){ Id = 6, bookTitle = "MVC" , bookAuthor = "Zubair"},
           }; 
        }
    }
}
