using System;
using EmpMgt.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmpMgt.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{
		}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed department table
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "Marketing" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "Designs" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Products" });

            // seed employees table
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Mary",
                    LastName = "Linglang",
                    Email = "maryl@sample.com",
                    DateOfBirth = new DateTime(1982, 1, 19),
                    Gender = Data.Enums.Gender.Female,
                    Department = 1,
                    Photo = "images/mary.png"
                }
            );

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 2,
                   FirstName = "John",
                   LastName = "Longrich",
                   Email = "johnl@sample.com",
                   DateOfBirth = new DateTime(1989, 10, 10),
                   Gender = Data.Enums.Gender.Male,
                   Department = 1,
                   Photo = "images/john.png"
               }
           );

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 3,
                   FirstName = "Sara",
                   LastName = "Richards",
                   Email = "sarar@sample.com",
                   DateOfBirth = new DateTime(1994, 11, 1),
                   Gender = Data.Enums.Gender.Female,
                   Department = 2,
                   Photo = "images/sara.png"
               }
           );

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 4,
                   FirstName = "Sam",
                   LastName = "Fin",
                   Email = "samf@sample.com",
                   DateOfBirth = new DateTime(1984, 1, 6),
                   Gender = Data.Enums.Gender.Male,
                   Department = 3,
                   Photo = "images/sam.jpeg"
               }
           );

        }
    }
}

