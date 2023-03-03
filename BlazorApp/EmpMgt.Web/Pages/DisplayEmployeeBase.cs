﻿using System;
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

        public bool IsSelected { get; set; }

        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
        }
    }
}

