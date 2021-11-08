using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qna.Models;
using Qna.Models.DataModels;

namespace Qna.Controllers
{
    public class QnaController : Controller
    {
        QnaDbContext db = new QnaDbContext();
        // GET: Qna
        public ActionResult Index()
        {
            ViewBag.FirstCategory = db.Categories.ToList().First();
            return View();
        }

        public ActionResult AddCategory()
        {
            var category = new Categeory()
            {
                Name = "Angular",
                Description = "Question related to angular",
                CreatedBy = "Pavan",
                ModifiedBy = "Pavan",
                DateCreated = DateTime.Today,
                DateModified = DateTime.Today
            };

            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        }
    }
}