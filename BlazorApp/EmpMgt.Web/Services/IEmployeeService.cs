using System;
using EmpMgt.Data.Entities;

namespace EmpMgt.Web.Services
{
	public interface IEmployeeService<T>: IBaseService<T>
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}

