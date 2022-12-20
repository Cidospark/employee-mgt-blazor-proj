using System;
using System.Web;
using EmpMgt.Data.Enums;
using EmpMgt.Web.Models;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace EmpMgt.Web.Services
{
	public class BaseService : IBaseService
	{
        private readonly IHttpClientFactory httpClient;

        public BaseService(IHttpClientFactory httpClient)
		{
            this.httpClient = httpClient;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public async Task<T> MakeRequestAsync<T>(ApiRequestModel apiRequestModel)
        {
            try
            {
                var client = httpClient.CreateClient("EmpMgt API");
                HttpRequestMessage message = new HttpRequestMessage();

                // set headers
                message.Headers.Add("Accept", "application/json");

                // setup query string [optional] and message Uri
                var queryParams = new Dictionary<string, string>();
                if (apiRequestModel.QueryParams.Count > 0)
                {
                    foreach (var query in apiRequestModel.QueryParams)
                    {
                        queryParams[query.Key] = query.Value;
                    }
                }
                var uriBuilder = new Uri(QueryHelpers.AddQueryString(apiRequestModel.Url, queryParams));
                message.RequestUri = uriBuilder;

                // set content
                client.DefaultRequestHeaders.Clear();
                if (apiRequestModel.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequestModel.Data),
                        System.Text.Encoding.UTF8, "application/json");
                }

                // set method
                HttpResponseMessage apiResponse = null;
                switch (apiRequestModel.ApiType)
                {
                    case ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;

                    case ApiType.GET:
                        message.Method = HttpMethod.Get;
                        break;

                    case ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;

                    case ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;

                    case ApiType.PATCH:
                        message.Method = HttpMethod.Patch;
                        break;

                    case ApiType.HEAD:
                        message.Method = HttpMethod.Head;
                        break;
                }

                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<T>(apiContent);
                return result;
            }
            catch (Exception ex)
            {
                var err = new ResponseModel<string>
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(ex.Message) },
                    IsSuccess = false
                };

                return (T) Convert.ChangeType(err,typeof(T));
            }
        }
    }
}

