using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MyConsoleApp
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Specialisation { get; set; }
        public int ConsultationFees{ get; set; }
    }

    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=DOCTOR;User Id=SA;Password=MyPassword#321;TrustServerCertificate=True");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            using(var context = new DoctorDbContext()){
                Doctor NewDoctor = new Doctor()
                {
                    DoctorName = "Dhanush Sn",
                    Specialisation = "ENT",
                    ConsultationFees=1200
                };
            // Adding the new doctor info
            context.Doctors.Add(NewDoctor);
            context.SaveChanges();

                // Display the details 
                foreach (var record in context.Doctors)
                {
                    Console.Write(record.DoctorId + " ");
                    Console.Write(record.DoctorName + " ");
                    Console.Write(record.Specialisation + " ");
                    Console.Write(record.ConsultationFees + " ");
                    Console.WriteLine();
                }
            
        }
}
    }
}