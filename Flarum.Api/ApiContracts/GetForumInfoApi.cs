using System.Text.Json.Serialization;
using Flarum.Api.Bases;
using Flarum.Api.Models.ResponseModel;
using Kengwang.Toolkit;

namespace Flarum.Api.ApiContracts
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
        [JsonPropertyName("attributes")] public FlarumForumDto ForumInfo { get; set; }
    }
}
