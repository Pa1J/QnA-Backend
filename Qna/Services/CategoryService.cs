using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Qna.Models;
namespace Qna.Services
{
    public class CategoryService
    {
        QnaDbContext db = new QnaDbContext();

        public Boolean AddCategory(Models.CoreModels.Categeory newCategeory)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.CoreModels.Categeory, Models.DataModels.Categeory>();
            });
            IMapper mapper = config.CreateMapper();

            var newDataCategeory = mapper.Map<Models.CoreModels.Categeory, Models.DataModels.Categeory>(newCategeory);
            db.Categories.Add(newDataCategeory);
            db.SaveChanges();
            return true;
        }
        public List<Models.CoreModels.CategoryView> GetCategoryViewItems()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Models.DataModels.CategoryView, Models.CoreModels.CategoryView>();
            });
            IMapper mapper = config.CreateMapper();

            List<Models.CoreModels.CategoryView> CoreCategoryViewList = new List<Models.CoreModels.CategoryView>();
            db.CategoryViews.ToList().ForEach(categoryViewItem =>
           {
               var CategoryView = mapper.Map<Models.DataModels.CategoryView, Models.CoreModels.CategoryView>(categoryViewItem);
               CoreCategoryViewList.Add(CategoryView);
           });
            return CoreCategoryViewList;
        }
    }
}