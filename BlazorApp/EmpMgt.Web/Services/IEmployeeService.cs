using System;
using EmpMgt.Data.Entities;

namespace EmpMgt.Web.Services
{
	public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}

