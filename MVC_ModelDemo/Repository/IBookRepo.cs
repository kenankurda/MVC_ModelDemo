using MVC_ModelDemo.Models;
using System.Collections.Generic;

namespace MVC_ModelDemo.Repository
{
    public interface IBookRepo
    {
        List<Book> Database { get; }

        Book Add(Book book);
        Book Delete(int id);
        Book EditBook(int id);
        List<Book> GetAllBooks();
        Book GetDetail(int id);
        List<Book> GetUpdatedList();
        Book UpdateBook(Book newbook);
    }
}