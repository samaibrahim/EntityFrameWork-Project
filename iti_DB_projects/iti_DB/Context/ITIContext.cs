using iti_DB.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iti_DB.Context
{
    public class ITIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-83JFADP\\SQLEXPRESS;DataBase=ITIEF;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //composite key for the Student_Course
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.St_Id, sc.Crs_Id });

            //composite key for the Ins_Cources
            modelBuilder.Entity< Ins_Crs >()
                .HasKey(ic => new {ic.Crs_Id,ic.Ins_Id});

            //one to one
            modelBuilder.Entity<Department>()
                .HasOne(d=>d.Manager_ins)
                .WithOne(d=>d.Manager_ins)
                .HasForeignKey<Department>(d=>d.Dept_Maneger)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

              
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student_Course> Student_Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Ins_Crs> Ins_Cources { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }


    }
}
