using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Flarum.Api.Bases;
using Flarum.Api.Models.ResponseModel;

namespace Flarum.Api.ApiContracts
{
    public class GetSingleDiscussionsApi :
        ApiBase<GetAllDiscussionsActualRequest, GetAllDiscussionsRequest, GetAllDiscussionsResponse, ErrorResultBase>
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ApiPath => "/api/discussions";

        public override Task MapRequest(GetAllDiscussionsRequest? request)
        {
            if (request is not null)
            {
                ActualRequest = new ()
                {
                    DiscussionId = request.DiscussionId
                };
                    
            }
            return Task.CompletedTask;
        }
    }

    public class GetSingleDiscussionsRequest : RequestBase
    {
        public required string DiscussionId { get; set; }
    }
    public class GetSingleDiscussionsActualRequest : ActualRequestBase
    {
        public required string DiscussionId { get; set; }
    }
    public class GetSingleDiscussionsResponse : ResponseBase
    {
        [JsonPropertyName("links")] public Link Links { get; set; }
        [JsonPropertyName("data")] public DiscussionsInfo[]? Discussions { get; set; }

        public class Link
        {
            [JsonPropertyName("first")] public string FirstLink { get; set; }
            [JsonPropertyName("next")] public string NextLink { get; set; }
        }

        public class DiscussionsInfo : FlarumDataBase
        {
            [JsonPropertyName("attributes")] public FlarumDiscussionDto FlarumDiscussion { get; set; }
        }
    }
}