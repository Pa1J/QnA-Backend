using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.DataModels
{
    public class Answer
    {
        public int Id { get; set; }
        public int AnsweredBy { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public DateTime AnsweredOn { get; set; }
        public bool IsBestSolution { get; set; }

        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}