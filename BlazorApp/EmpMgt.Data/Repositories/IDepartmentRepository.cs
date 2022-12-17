using System;
using EmpMgt.Data.Entities;

namespace EmpMgt.Data.Repositories
{
	public interface IDepartmentRepository
	{
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}

