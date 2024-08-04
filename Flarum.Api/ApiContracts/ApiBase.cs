using Flarum.Api.Bases;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flarum.Api.ApiContracts
{
    public abstract class ApiBase<TRequest, TResponse, TError> 
        : ApiContractBase<TRequest, TResponse, TError>
        where TRequest : RequestBase
        where TResponse : ResponseBase
        where TError : ErrorResultBase
        
    {
        public override HttpMethod Method => null;

        public override string ApiPath => null;

        public override HttpRequestMessage GenerateRequestMessage(FlarumApiHandlerOption option)
        {
            var request = new HttpRequestMessage();
            var fullUri = $"{url}/{ApiPath}";
            request.Method = Method;
            request.RequestUri = new Uri(fullUri);
            request.Headers.Add("UserAgent", UserAgent);
            var cookies = option.Cookies.ToDictionary(t => t.Key, t => t.Value);
            foreach (var keyValuePair in Cookies)
            {
                cookies[keyValuePair.Key] = keyValuePair.Value;
            }
            return request;
        }

        public override async IFlarumModel ProcessResponseAsync<TResult>(HttpResponseMessage response, FlarumApiHandlerOption option)
        {
            if (!response.IsSuccessStatusCode)
            {
                return new ErrorResultBase((int)response.StatusCode, $"请求返回 HTTP 代码: {response.StatusCode}");
            }
            
        }
    }
}
