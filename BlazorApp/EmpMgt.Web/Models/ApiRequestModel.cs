using System;
using EmpMgt.Data.Enums;

namespace EmpMgt.Web.Models
{
	public class ApiRequestModel
	{
        public ApiType ApiType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
        public Dictionary<string,string> QueryParams { get; set; }

        public ApiRequestModel()
        {
            QueryParams = new Dictionary<string, string>();
        }
    }
}