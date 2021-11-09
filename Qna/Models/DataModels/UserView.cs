using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.DataModels
{
    public class UserView
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string ProPicUrl { get; set; }
        public int QuesitonsAsked { get; set; }
        public int QuestionsAnswered { get; set; }
        public int Solved { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}