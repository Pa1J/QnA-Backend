using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qna.Models;
using Qna.Models.DataModels;
using Qna.Models.CoreModels;
using AutoMapper;

namespace Qna.Controllers
{
    public class ViewController : Controller
    {
        QnaDbContext db = new QnaDbContext();
        // GET: View
        public ActionResult CategoryView()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.CategoryView, Models.CoreModels.CategoryView>();
            });
            IMapper mapper = config.CreateMapper();
            List<Models.CoreModels.CategoryView> coreCatViewList = new List<Models.CoreModels.CategoryView>();
            db.CategoryViews.ToList().ForEach(catView =>
           {
               var coreCatView = mapper.Map<Models.DataModels.CategoryView, Models.CoreModels.CategoryView>(catView);
               coreCatViewList.Add(coreCatView);
           });
            ViewBag.CategoryViewList = coreCatViewList;
            return View();
        }
        public ActionResult UserView()
        {
            ViewBag.UserViewList = db.UsersViews.ToList();
            return View();
        }

        public ActionResult AnswerView()
        {
            ViewBag.AnswerViewList = db.AnswerViews.ToList();
            return View();
        }
    }
}