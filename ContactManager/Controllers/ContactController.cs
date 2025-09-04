using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{

    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = context.Contacts
                         .Include(c => c.Category)  
                         .FirstOrDefault(c => c.ContactId == id);

            return View(contact);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid) {
                // if else statement that determines if ContactId is 0 or not if it is 0 then it will navigate to the Add contact else it will navigate to edit
                if (contact.ContactId == 0)
                {
                    contact.DateAdded = DateTime.Now;
                    context.Contacts.Add(contact);
                }
                else
                    context.Contacts.Update(contact);
                //saves changes to the database
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //If the contactId = 0 the ViewBag.Action will be Add else Edit
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
