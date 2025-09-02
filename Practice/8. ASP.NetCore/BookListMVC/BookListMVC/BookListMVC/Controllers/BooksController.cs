using BookListMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Book Book { get; set; } // Create a book object to post or Insert a new book
        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id) // ? is for that, id can be passed or not
        {
            Book = new Book();
            if (id == null) // if id is not passed, means, it is for CREATE request.(user want to insert new book)
            {
                return View(Book);
            }
            //if id is passed, means it is for UPDATE.
            Book = _db.Books.FirstOrDefault(u => u.Id == id); // here it matches the entered with the data base.
            if (Book == null)
            {
                return NotFound(); // If id is not matched, return this
            }
            return View(Book); //If id matched, return this.
        }

        //Following code is for post method on creat & update button at Upsert.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Book.Id == 0)
                {
                    //Create
                    _db.Books.Add(Book);
                }
                else
                {
                    //Update
                    _db.Books.Update(Book);
                }
                _db.SaveChanges();
                //After it saves the changes, It redirects to Index action (given above)& diplays all the books.
                return RedirectToAction("Index");
            }
            return View(Book);
        }

        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Books.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookFromDb = await _db.Books.FirstOrDefaultAsync(u => u.Id == id);
            if (bookFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _db.Books.Remove(bookFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
