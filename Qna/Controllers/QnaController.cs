using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qna.Models;
using Qna.Models.DataModels;
using AutoMapper;

namespace Qna.Controllers
{
    public class QnaController : Controller
    {
        QnaDbContext db = new QnaDbContext();
        // GET: Qna
        public ActionResult Index()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        public ActionResult GetQuestions()
        {
            ViewBag.Questions = db.Questions.ToList();
            return View();
        }

        public ActionResult GetUsers()
        {
            ViewBag.Users = db.Users.ToList();
            return View();
        }

        public ActionResult AddCategory()
        {
            var category = new Categeory()
            {
                Name = "Database Management",
                Description = "Question related to database management",
                CreatedBy = "Ram",
                ModifiedBy = "Ram",
                DateCreated = DateTime.Today,
                DateModified = DateTime.Today
            };

            db.Categories.Add(category);
            db.SaveChanges();
            return View();
        } 

        public ActionResult AddUser()
        {
            var user = new Users()
            {
                Name = "Ram",
                Designation = "Software Engineer",
                Department = "QA Team",
                Location = "Hyderabad",
                CreatedBy = "Pavan",
                Email = "ram@keka.com",
                DateCreated = DateTime.Today,
                ModifiedBy = "Pavan",
                DateModified = DateTime.Today
            };
            db.Users.Add(user);
            db.SaveChanges();
            return View();
        }

        public ActionResult AddQuestion()
        {
            var question = new Question()
            {
                QuestionedBy = 3,
                Statement = "how to create tables in database",
                Description = "while creating a db, how can i create tables to store data in db",
                CategoryId = 6,
                QuestionedOn = DateTime.Today,
                CreatedBy = "Pavan",
                ModifiedBy = "Pavan",
                DateCreated = DateTime.Today,
                DateModified = DateTime.Today,
                IsResolved = 0

            };
            /*var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Question, Question>();
            });
            IMapper mapper = config.CreateMapper();*/
            db.Questions.Add(question);
            db.SaveChanges();
            return View();
        }
    }
}