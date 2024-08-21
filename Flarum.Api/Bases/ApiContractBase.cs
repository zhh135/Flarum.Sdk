using Flarum.Api.Bases.ModelBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Api.Bases
{
    public abstract class ApiContractBase<TActualRequest, TRequest, TResponse, TError>
        where TActualRequest : ActualRequestBase
        where TRequest : RequestBase
        where TResponse : ResponseBase, new()
        where TError : ErrorResultBase
    {
        public abstract HttpMethod Method { get; }
        public abstract string ApiPath {get;}
        public virtual Dictionary<string, string> Cookies { get; } = new();
        public virtual string? UserAgent { get; } = null;

        public TActualRequest ActualRequest { get; set; }
        public TRequest Request { get; set; }
        public TResponse Response { get; set; } 
        public TError Error { get; set; }

        protected ApiContractBase()
        {

        }

        public abstract Task<HttpRequestMessage> GenerateRequestMessageAsync(FlarumApiHandlerOption option);

        public abstract Task<HttpRequestMessage> GenerateRequestMessageAsync<TActualRequestModel>(TActualRequestModel actualRequest, FlarumApiHandlerOption option);

        public abstract Task MapRequest(TRequest? request);

        public abstract Task<Results<TResponse, ErrorResultBase>> ProcessResponseAsync(HttpResponseMessage response, FlarumApiHandlerOption option);

        public abstract Task<Results<TResponseModel, ErrorResultBase>> ProcessResponseAsync<TResponseModel>(HttpResponseMessage response, FlarumApiHandlerOption option);
    }
}
