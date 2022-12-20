using System;
using EmpMgt.Web.Models;

namespace EmpMgt.Web.Services
{
	public interface IBaseService<T> : IDisposable
	{
		ResponseModel<T> responseModel { get; set; }
		Task<T> MakeRequestAsync(ApiRequestModel apiRequestModel);
	}
}

