using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Qna.Models.DataModels
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int QuestionedBy { get; set; }
        public string Statement { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime QuestionedOn { get; set; }
        public int IsResolved { get; set; }

        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }

    }
}