using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Qna.Models.DataModels;

namespace Qna.Models
{
    public class QnaDbContext : DbContext
    {
        public QnaDbContext()
            :base("name=QnaDbConnection")
        {

        }

        public DbSet<Categeory> Categories { get; set; }
    }
}