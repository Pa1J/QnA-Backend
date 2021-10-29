using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qna.Models.CoreModels
{
    public class Liked
    {
        public int Id { get; set; }
        public int LikedBy { get; set; }
        public int AnswerId { get; set; }
        public bool IsLiked { get; set; }
        public DateTime LikedOn { get; set; }

    }
}