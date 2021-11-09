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
            : base("name=QnaDbConnection")
        {

        }

        public DbSet<Categeory> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<CategoryView> CategoryViews { get; set; }
        public DbSet<UserView> UsersViews { get; set; }
        public DbSet<AnswerView> AnswerViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryView>().HasKey(t => t.Name).ToTable(nameof(CategoryView));
            modelBuilder.Entity<UserView>().HasKey(t => t.Name).ToTable(nameof(UserView));
            modelBuilder.Entity<AnswerView>().HasKey(t => t.AnsweredBy).ToTable(nameof(AnswerView));
        }


    }
}