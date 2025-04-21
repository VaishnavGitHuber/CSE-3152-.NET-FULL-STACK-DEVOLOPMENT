using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MyConsoleApp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }

    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=STUDENT_EF;User Id=SA;Password=MyPassword#321;TrustServerCertificate=True");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var Context = new StudentDbContext())
            {
                Student NewStudent = new Student()
                {
                    StudentName = "Dhanush SN"
                };
                Context.Students.Add(NewStudent);
                Context.SaveChanges();

                foreach (var item in Context.Students) {
                    Console.WriteLine(item.StudentId + " " + item.StudentName);
                }
            
            }
            

        }
    }
}