using Flarum.Api.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Api.ApiContracts
{
    public class GetDiscussionsApi : ApiBase<GetDiscussionsRequest, GetDiscussinsResponse, ErrorResultBase>
    {
        public override HttpMethod Method => HttpMethod.Get;

        public override string ApiPath => "api/discussions";

        public override HttpRequestMessage GenerateRequestMessage(FlarumApiHandlerOption option)
        {
            return base.GenerateRequestMessage(option);
        }

        public override TResult ProcessResponseAsync<TResult>(HttpResponseMessage response)
        {
            return base.ProcessResponseAsync<TResult>(response);
        }
    }

    public class GetDiscussionsRequest : RequestBase
    {

    }

    public class GetDiscussinsResponse : ResponseBase
    {

    }
}
