using System;
using EmpMgt.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace EmpMgt.Web.Pages
{
	public class EmployeeListBase : ComponentBase
	{
		public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
		{
			Employees = new List<Employee>
			{
				new Employee
				{
					EmployeeId = 1,
					FirstName = "Mary",
					LastName = "Linglang",
					Email = "maryl@sample.com",
					DateOfBirth = new DateTime(1982, 19, 1),
					Gender = Data.Enums.Gender.Female,
					Department = new Department { DepartmentId = 1, DepartmentName = "Marketing" },
					Photo = "images/mary.png"
				},
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "John",
                    LastName = "Longrich",
                    Email = "johnl@sample.com",
                    DateOfBirth = new DateTime(1989, 10, 10),
                    Gender = Data.Enums.Gender.Male,
                    Department = new Department { DepartmentId = 1, DepartmentName = "Marketing" },
                    Photo = "images/john.png"
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Sara",
                    LastName = "Richards",
                    Email = "sarar@sample.com",
                    DateOfBirth = new DateTime(1994, 11, 1),
                    Gender = Data.Enums.Gender.Female,
                    Department = new Department { DepartmentId = 2, DepartmentName = "Designs" },
                    Photo = "images/sara.png"
                },
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Sam",
                    LastName = "Fin",
                    Email = "samf@sample.com",
                    DateOfBirth = new DateTime(1984, 1, 6),
                    Gender = Data.Enums.Gender.Male,
                    Department = new Department { DepartmentId = 3, DepartmentName = "Product" },
                    Photo = "images/sam.png"
                }
            };
		}
	}
}

