using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Api.Bases
{
    public abstract class ApiContractBase<TRequest, TResponse, TError>
        where TRequest : RequestBase
        where TResponse : ResponseBase
        where TError : ErrorResultBase
    {
        public abstract HttpMethod Method { get; }
        public abstract string ApiPath {get;}
        public virtual Dictionary<string, string> Cookies { get; } = new();
        public virtual string? UserAgent { get; } = null;

        public TRequest Request { get; set; }
        public TResponse Response { get; set; } 
        public TError Error { get; set; }
        public string url { get; }

        protected ApiContractBase()
        {

        }

        public abstract Task MapRequest(TRequest? request, string token);

        public abstract HttpRequestMessage GenerateRequestMessage();
    }
}
