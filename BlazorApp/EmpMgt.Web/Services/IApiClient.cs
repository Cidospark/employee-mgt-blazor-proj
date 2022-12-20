using System;
using EmpMgt.Web.Models;

namespace EmpMgt.Web.Services
{
	public interface IApiClient : IDisposable
	{
		Task<T> MakeRequestAsync<T>(ApiRequestModel apiRequestModel);
	}
}

