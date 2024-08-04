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

        public override HttpRequestMessage GenerateRequestMessage()
        {
            return base.GenerateRequestMessage();
        }

        public override async Task<string> MapRequest(GetDiscussionsRequest? request, string token)
        {
            return await base.MapRequest(request, token);
        }
    }

    public class GetDiscussionsRequest : RequestBase
    {

    }

    public class GetDiscussinsResponse : ResponseBase
    {

    }
}
