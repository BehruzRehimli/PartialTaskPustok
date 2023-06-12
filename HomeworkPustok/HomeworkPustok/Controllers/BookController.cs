using HomeworkPustok.DAL;
using HomeworkPustok.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeworkPustok.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokDbContext _context;

        public BookController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            var data = _context.Books.Include(x=>x.Genre).Include(x=>x.BookTag).ThenInclude(x=>x.Tag).Include(x=>x.Author).Include(x=>x.Images.Where(x=>x.PhotoNumber==1)).FirstOrDefault(x => x.Id == id);
            return PartialView("_BookModalPartial",data);
        }
    }
}
