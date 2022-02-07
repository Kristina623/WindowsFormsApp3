using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp3
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Водитель> Водитель { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.Login1)
                .IsUnicode(false);
        }
    }
}
