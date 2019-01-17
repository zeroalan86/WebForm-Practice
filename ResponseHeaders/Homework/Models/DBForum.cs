namespace Homework.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBForum : DbContext
    {
        public DBForum()
            : base("name=DBForum")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
