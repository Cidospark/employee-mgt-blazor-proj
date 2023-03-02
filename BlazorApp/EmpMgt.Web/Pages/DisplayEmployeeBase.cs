using System;
using EmpMgt.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace EmpMgt.Web.Pages
{
	public class DisplayEmployeeBase : ComponentBase
	{
        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}

