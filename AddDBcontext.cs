using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public class AddDBcontext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Courses> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Department> Departments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TASK3;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grade>()
                .HasOne(b => b.Enrollment)
                .WithOne(i => i.Grade)
                .HasForeignKey<Enrollment>(b => b.Gradeid);

            modelBuilder.Entity<Teacher>()
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(p => p.DepartmentId);

            modelBuilder.Entity<Courses>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(p => p.TeacherId);

              
        }
    }
}
