using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNoteRedBadge.WebMVC.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var model = new CategoryListItem[0];
            return View();
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryCreate model)
        {
            if (!ModelState.IsValid)
            {

            }

            return View(model);
        }
    }
}