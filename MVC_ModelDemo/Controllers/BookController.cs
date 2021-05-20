using Microsoft.AspNetCore.Mvc;
using MVC_ModelDemo.Models;
using MVC_ModelDemo.Repository;
using MVC_ModelDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepo _bookrepository = new BookRepo();
        public IActionResult Index()
        {
            Book book = new Book();
            book.Id = 1;
            book.Title = "Mvc Core";
            book.Author = "Murach";
            book.YearPublished = 2020;
            book.Pages = 380;

            Author author = new Author();
            author.Id = 22;
            author.FirstName = "Tony";
            author.LastName = "Montana";

            AuthorBook authorbook = new AuthorBook();
            authorbook.Book = book;
            authorbook.Author = author;

            //ViewBag.Book = book;
            return View(authorbook);
        }
        public IActionResult GetAllBooks()
        {
           var books= _bookrepository.GetAllBooks();
           return View("GetAllBooks", _bookrepository.Database);
        }
        public IActionResult GetUpdatedList() 
        { 
            var books = _bookrepository.GetUpdatedList();
            return View("GetUpdatedList", _bookrepository.Database);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var book = _bookrepository.GetDetail(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookrepository.EditBook(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book modifiedBook)
        {
            var newBook = _bookrepository.UpdateBook(modifiedBook);
            return View("GetUpdatedList", _bookrepository.Database);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
           var book = _bookrepository.GetDetail(id);
            return View(book);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteBook(int id)
        {
            _bookrepository.Delete(id);
            return View("GetAllBooks", _bookrepository.Database);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {

            if (ModelState.IsValid)
            {
                _bookrepository.Add(book);
                return View("GetUpdatedList", _bookrepository.Database);
            }
            else
            {
                return View();
            }
            
        }





        [HttpGet]
        public IActionResult Dummy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dummy(string personName)
        {
            return View();
        }
    }
}
