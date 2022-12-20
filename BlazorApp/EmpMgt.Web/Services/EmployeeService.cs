using System;
using Microsoft.AspNetCore.Components;
using EmpMgt.Data.Entities;
using System.Net.Http.Json;
using EmpMgt.Web.Models;
using EmpMgt.Data.Enums;

namespace EmpMgt.Web.Services
{
	public class EmployeeService : ApiClient, IEmployeeService
	{
        private readonly IHttpClientFactory apiClient;
        private readonly IConfiguration config;

        public EmployeeService(IHttpClientFactory apiClient, IConfiguration config ):base(apiClient)
		{
            this.apiClient = apiClient;
            this.config = config;
        }

        public async Task<ResponseModel<IEnumerable<Employee>>> GetEmployees()
        {
            return await this.MakeRequestAsync<ResponseModel<IEnumerable<Employee>>>(new ApiRequestModel
            {
                Url = config.GetSection("API:BaseURL").Value,
                ApiType = ApiType.GET
            });
        }
    }
}

