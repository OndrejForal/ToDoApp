using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDbExercise
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
  
           modelBuilder.Entity<Asignee>().HasMany(a=>a.Todos).WithOne(a=>a.Asignee).HasForeignKey(a=>a.AsigneeId).OnDelete(DeleteBehavior.SetNull);
        }
        public DbSet<ToDo> Todo { get; set; }
        public DbSet<Asignee> Asignees { get; set; }

    }
}
