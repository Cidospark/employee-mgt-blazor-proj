using System;
using EmpMgt.Data.Entities;
using EmpMgt.Web.Models;

namespace EmpMgt.Web.Services
{
	public interface IEmployeeService: IApiClient
    {
        Task<ResponseModel<IEnumerable<Employee>>> GetEmployees();
    }
}

