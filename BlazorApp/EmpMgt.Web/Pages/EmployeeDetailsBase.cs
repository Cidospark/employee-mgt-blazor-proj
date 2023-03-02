using System;
using EmpMgt.Web.Models;
using EmpMgt.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using EmpMgt.Data.Entities;

namespace EmpMgt.Web.Pages
{
	public class EmployeeDetailsBase : ComponentBase
	{
		public Employee Employee { get; set; } = new Employee();

		[Inject]
		public IEmployeeService EmployeeService { get; set; }

		[Parameter]
		public string Id { get; set; }

		protected async override Task OnInitializedAsync()
		{
			Id = Id ?? "1";
			var result = await EmployeeService.GetEmployee(int.Parse(Id));
			if (result.IsSuccess)
			{
				Employee = result.Result;
			}
			else
			{

			}
		}
        protected string Colour { get; set; } = "background-color:white";
        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

        public string Description { get; set; } = string.Empty;
    }
}

