using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {

        private ContactContext context {  get; set; }

        public HomeController(ContactContext ctx) => context = ctx;

        public IActionResult Index()
        {
            //Orders contacts by last name then by first name and includes the Category data
            var contacts = context.Contacts.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).Include(c => c.Category).ToList();
            return View(contacts);
        }

        

        
    }
}
