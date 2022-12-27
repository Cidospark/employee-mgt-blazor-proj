using System;
using System.Net.Http;
using EmpMgt.Data.Entities;
using EmpMgt.Web.Models;
using EmpMgt.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmpMgt.Web.Pages
{
	public class EmployeeListBase : ComponentBase
	{
        //[Inject]
        //public IEmployeeService EmployeeService { get; set; }
        [Inject] private HttpClient httpClient { get; set; }
        [Inject] private IConfiguration config { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }

		public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //await Task.Run(LoadEmployees);
            //var result = await EmployeeService.GetEmployees();
            var result = await httpClient.GetAsync(config.GetSection("API:BaseURL").Value + "/api/Employees");


            if (!result.IsSuccessStatusCode)
                navigationManager.NavigateTo("Error");


            if (result.IsSuccessStatusCode)
            {
                Employees = await result.Content.ReadFromJsonAsync<IEnumerable<Employee>>();
            }
            else
                Employees = null;
        }

        private void LoadEmployees()
		{
            System.Threading.Thread.Sleep(2000);

            var deptList = new List<Department>
            {
                new Department { DepartmentId = 1, DepartmentName = "Marketing" },
                new Department { DepartmentId = 2, DepartmentName = "Designs" },
                new Department { DepartmentId = 3, DepartmentName = "Product" }
            };

			Employees = new List<Employee>
			{
				new Employee
				{
					EmployeeId = 1,
					FirstName = "Mary",
					LastName = "Linglang",
					Email = "maryl@sample.com",
					DateOfBirth = new DateTime(1982, 1, 19),
					Gender = Data.Enums.Gender.Female,
					DepartmentId = deptList[0].DepartmentId,
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
                    DepartmentId = deptList[0].DepartmentId,
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
                    DepartmentId = deptList[1].DepartmentId,
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
                    DepartmentId = deptList[2].DepartmentId,
                    Photo = "images/sam.jpeg"
                }
            };
		}
	}
}



//private List<Resource> items = new();
//[Inject] private HttpClient httpClient { get; set; }
//[Inject] private IConfiguration config { get; set; }

//protected override async Task OnInitializedAsync()
//{
//    var result = await httpClient.GetAsync(config["apiUrl"] + "/api/Resource");

//    if (result.IsSuccessStatusCode)
//    {
//        items = await result.Content.ReadFromJsonAsync<List<Resource>>();
//    }
//}