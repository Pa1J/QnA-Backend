using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.DataModels
{
    public class Liked
    {
        public int Id { get; set; }
        public int LikedBy { get; set; }
        public int AnswerId { get; set; }
        public bool IsLiked { get; set; }
        public DateTime LikedOn { get; set; }

        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}