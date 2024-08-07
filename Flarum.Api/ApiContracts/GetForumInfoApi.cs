using Flarum.Api.Bases;

namespace Flarum.Api
{
    public class GetForumInfoApi : ApiBase<GetForumInfoActualRequest, GetForumInfoRequest, GetForumInfoResponse, ErrorResultBase>
    {
        public override string ApiPath => "/api";
        public override HttpMethod Method => HttpMethod.Get;

        public override Task MapRequest(GetForumInfoRequest? request)
        {
            return Task.CompletedTask;
        }
    }

    public class GetForumInfoActualRequest : ActualRequestBase
    {

    }

    public class GetForumInfoRequest : RequestBase
    {

    }

    public class GetForumInfoResponse : CodedResponseBase
    {

    }
}
