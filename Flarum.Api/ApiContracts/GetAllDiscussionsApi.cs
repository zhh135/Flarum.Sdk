using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flarum.Api.Bases;

namespace Flarum.Api.ApiContracts
{
    public class GetAllDiscussionsApi : 
        ApiBase<GetAllDiscussionsActualRequest, GetAllDiscussionsRequest, GetAllDiscussionsResponse, ErrorResultBase>
    {
        public override HttpMethod Method => HttpMethod.Get;

    }

    public class GetAllDiscussionsRequest : RequestBase
    {

    }
    public class GetAllDiscussionsActualRequest : ActualRequestBase
    {

    }
    public class GetAllDiscussionsResponse : ResponseBase
    {

    }
}
