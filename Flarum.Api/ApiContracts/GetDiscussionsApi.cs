using Flarum.Api.Bases;
using Kengwang.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Api.ApiContracts
{
    public class GetDiscussionsApi : ApiBase<GetDiscussionsActualRequest, GetDiscussionsRequest, GetDiscussinsResponse, ErrorResultBase>
    {
        public override HttpMethod Method => HttpMethod.Get;

        public override string ApiPath => "api/discussions";

        

        public override Task MapRequest(GetDiscussionsRequest request)
        {
            throw new NotImplementedException();
        }

        
    }

    public class GetDiscussionsActualRequest : ActualRequestBase
    {

    }

    public class GetDiscussionsRequest : RequestBase
    {

    }

    public class GetDiscussinsResponse : ResponseBase
    {

    }
}
