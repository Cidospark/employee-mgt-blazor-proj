using System;
using EmpMgt.Data.Entities;
using EmpMgt.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmpMgt.Web.Pages
{
	public class EditEmployeeBase : ComponentBase
	{
		public Employee Employee { get; set; } = new Employee();

		[Inject]
		public IEmployeeService EmployeeService { get; set; }

		[Parameter]
		public string Id { get; set; }

		protected async override Task OnInitializedAsync()
		{
			Employee = (await EmployeeService.GetEmployee(int.Parse(Id))).Result;
		}
	}
}

