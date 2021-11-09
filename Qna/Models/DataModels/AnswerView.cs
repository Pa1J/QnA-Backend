using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.DataModels
{
    public class AnswerView
    {
        public string AnsweredUserName { get; set; }
        public string Description { get; set; }
        public int IsBestSolution { get; set; }
        public string ProPicUrl { get; set; }
        public int AnsweredBy { get; set; }
        public DateTime AnsweredOn { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}