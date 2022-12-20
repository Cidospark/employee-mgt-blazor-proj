using System;
using EmpMgt.Web.Models;

namespace EmpMgt.Web.Services
{
	public interface IBaseService : IDisposable
	{
		Task<T> MakeRequestAsync<T>(ApiRequestModel apiRequestModel);
	}
}

