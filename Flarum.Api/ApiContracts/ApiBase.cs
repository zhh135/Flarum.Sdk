using Flarum.Api.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public override HttpRequestMessage GenerateRequestMessage()
        {
            var request = new HttpRequestMessage();
            var fullUri = $"{url}/{ApiPath}";
            request.Method = Method;
            request.RequestUri = new Uri(fullUri);
            request.Headers.Add("UserAgent", UserAgent);
            return request;
        }

        public override Task<string> MapRequest(TRequest? request, string token)
        {
            HttpRequestMessage message = GenerateRequestMessage();
            HttpResponseMessage response = new HttpClient().SendAsync(message).Result;
            return response.Content.ReadAsStringAsync();
        }
    }
}
