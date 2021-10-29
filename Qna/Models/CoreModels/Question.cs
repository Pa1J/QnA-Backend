using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class Question
    {
        public int Id { get; set; }
        public int QuestionedBy { get; set; }
        public string Statement { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime QuestionedOn { get; set; }
        public bool IsResolved { get; set; }

    }
}