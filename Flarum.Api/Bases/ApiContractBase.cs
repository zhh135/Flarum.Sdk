using Kengwang.Toolkit;
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
        where TResponse : ResponseBase
        where TError : ErrorResultBase
    {
        public abstract HttpMethod Method { get; }
        public abstract string ApiPath {get;}
        public virtual Dictionary<string, string> Cookies { get; } = new();
        public virtual string? UserAgent { get; } = null;

        public TActualRequest actualRequest { get; set; }
        public TRequest Request { get; set; }
        public TResponse Response { get; set; } 
        public TError Error { get; set; }

        protected ApiContractBase()
        {

        }

        public abstract HttpRequestMessage GenerateRequestMessage(FlarumApiHandlerOption option);

        public abstract Task MapRequest(TRequest? request);

        public abstract Task<Results<TResponseModel, ErrorResultBase>> ProcessResponse<TResponseModel>(HttpResponseMessage response, FlarumApiHandlerOption option);
    }
}
