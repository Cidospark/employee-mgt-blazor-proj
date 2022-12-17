﻿using System;
using EmpMgt.Data.Entities;

namespace EmpMgt.Data.Repositories
{
	public interface IEmployeeRepository
	{
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
    }
}

