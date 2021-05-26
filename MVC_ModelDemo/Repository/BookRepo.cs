using MVC_ModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Repository
{
    public class BookRepo : IBookRepo
    {
        private static List<Book> _list = new List<Book>();
        public List<Book> Database
        {
            get { return _list; }
        }
        public List<Book> GetAllBooks()
        {
            return _list = FakeDatabase();
        }
        public List<Book> GetUpdatedList()
        {
            return _list;
        }

        public Book GetDetail(int id)
        {
            var foundedBook = _list.Find(book => book.Id.Equals(id));
            return foundedBook;
        }

        public Book EditBook(int id)
        {
            var foundedBook = _list.Find(book => book.Id.Equals(id));
            return foundedBook;
        }
        public Book UpdateBook(Book newbook)
        {
            var oldBook = _list.FirstOrDefault(b => b.Id.Equals(newbook.Id));
            _list.Remove(oldBook);
            _list.Add(newbook);
            return newbook;
        }

        public Book Delete(int id)
        {
            var bookToDelete = _list.Find(book => book.Id.Equals(id));
            _list.Remove(bookToDelete);
            return bookToDelete;
        }

        public Book Add(Book book)
        {
            _list.Add(book);
            return book;
        }
        private List<Book> FakeDatabase()
        {
            _list.Add(new Book() { Id = 10, Title = "Mvc Core", Author = "Jarno", YearPublished = 2020, Pages = 380 });
            _list.Add(new Book() { Id = 12, Title = "C#", Author = "Louis", YearPublished = 2019, Pages = 150 });
            _list.Add(new Book() { Id = 15, Title = "Angular", Author = "Saif", YearPublished = 2018, Pages = 280 });
            _list.Add(new Book() { Id = 20, Title = "Java Script", Author = "Sadki", YearPublished = 2021, Pages = 360 });
            _list.Add(new Book() { Id = 30, Title = "SQL Sever 2016", Author = "Emre", YearPublished = 2016, Pages = 560 });
            _list.Add(new Book() { Id = 50, Title = ".NET Core 5", Author = "Mauro", YearPublished = 2021, Pages = 660 });
            return _list;
        }
    }
}
