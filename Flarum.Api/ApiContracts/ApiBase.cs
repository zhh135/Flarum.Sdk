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

        public override string url => null;

        public override HttpRequestMessage GenerateRequestMessage()
        {
            var request = new HttpRequestMessage();
            request.Method = Method;
            request.RequestUri = new Uri(url);
            request.Headers.Add("UserAgent", UserAgent);
            return request;
        }

        public override Task MapRequest(TRequest? request, string token)
        {
            throw new NotImplementedException();
        }
    }
}
