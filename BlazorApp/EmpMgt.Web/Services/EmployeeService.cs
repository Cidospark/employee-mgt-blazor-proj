using System;
using Microsoft.AspNetCore.Components;
using EmpMgt.Data.Entities;
using System.Net.Http.Json;

namespace EmpMgt.Web.Services
{
	public class EmployeeService : IEmployeeService
	{
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
		{
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }
    }
}

