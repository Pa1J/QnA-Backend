using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class CategoryView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryTagsTotal { get; set; }
        public int CategoryTagsWeek { get; set; }
        public int CategoryTagsMonth { get; set; }
    }
}