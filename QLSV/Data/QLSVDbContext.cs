using Microsoft.EntityFrameworkCore;
using QLSV.Models;

namespace QLSV.Data
{
    public class QLSVDbContext : DbContext
    {
        public QLSVDbContext(DbContextOptions<QLSVDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();

            //Seed  Table
            modelBuilder.Entity<School>().HasData(
                new School { ID = 1, ShoolName = "Trường đại học 01" });
            modelBuilder.Entity<School>().HasData(
               new School { ID = 2, ShoolName = "Trường đại học 02" });
            modelBuilder.Entity<School>().HasData(
               new School { ID = 3, ShoolName = "Trường đại học 03" });
            //Class table
            modelBuilder.Entity<Class>().HasData(
              new Class { ID = 1, ClassName = "Lớp học 01", School_ID = 1 });
            modelBuilder.Entity<Class>().HasData(
             new Class { ID = 2, ClassName = "Lớp học 02", School_ID = 2 });
            modelBuilder.Entity<Class>().HasData(
             new Class { ID = 3, ClassName = "Lớp học 03", School_ID = 3 });
            modelBuilder.Entity<Class>().HasData(
             new Class { ID = 4, ClassName = "Lớp học 04", School_ID = 1 });
            modelBuilder.Entity<Class>().HasData(
             new Class { ID = 5, ClassName = "Lớp học 05", School_ID = 2 });
            modelBuilder.Entity<Class>().HasData(
             new Class { ID = 6, ClassName = "Lớp học 06", School_ID = 3 });
            //Student table
            modelBuilder.Entity<Student>().HasData(
             new Student { ID = 1, StudentName = "Học sinh 01", Class_ID = 1 });
            modelBuilder.Entity<Student>().HasData(
           new Student { ID = 2, StudentName = "Học sinh 02", Class_ID = 2 });
            modelBuilder.Entity<Student>().HasData(
           new Student { ID = 3, StudentName = "Học sinh 03", Class_ID = 3 });
            modelBuilder.Entity<Student>().HasData(
           new Student { ID = 4, StudentName = "Học sinh 04", Class_ID = 1 });
            modelBuilder.Entity<Student>().HasData(
           new Student { ID = 5, StudentName = "Học sinh 05", Class_ID = 2 });
            modelBuilder.Entity<Student>().HasData(
           new Student { ID = 6, StudentName = "Học sinh 06", Class_ID = 3 });
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}