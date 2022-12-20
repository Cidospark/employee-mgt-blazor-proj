using System;
namespace EmpMgt.Web.Models
{
	public class ResponseModel<T>
	{
		public bool IsSuccess { get; set; }
		public T Result { get; set; }
		public string DisplayMessage { get; set; }
		public List<string> ErrorMessages { get; set; }

		public ResponseModel()
		{
			ErrorMessages = new List<string>();
		}
	}
}

