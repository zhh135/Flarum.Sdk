using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Flarum.Api.Bases;
using Flarum.Api.Bases.ModelBases;
using Flarum.Api.Helpers;
using Flarum.Api.Models.ResponseModel;

namespace Flarum.Api.ApiContracts
{
    public class GetSingleDiscussionApi :
        ApiBase<GetSingleDiscussionActualRequest, GetSingleDiscussionRequest, GetSingleDiscussionResponse, ErrorResultBase>
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ApiPath => "/api/discussions";

        public override Task MapRequest(GetSingleDiscussionRequest? request)
        {
            ActualRequest = new()
            {
                DiscussionId = request.DiscussionId.ToString(),
            };

            return Task.CompletedTask;
        }

        public override async Task<HttpRequestMessage> GenerateRequestMessageAsync(FlarumApiHandlerOption option)
        {
            return await GenerateRequestMessageAsync(ActualRequest!, option).ConfigureAwait(false);
        }

        public override Task<HttpRequestMessage> GenerateRequestMessageAsync<TActualRequestModel>(TActualRequestModel actualRequest, FlarumApiHandlerOption option)
        {
            var request = new HttpRequestMessage();
            var req = actualRequest as GetSingleDiscussionActualRequest ?? new GetSingleDiscussionActualRequest();
            var fullUri = $"{option.Url}{ApiPath}/{req.DiscussionId}";
            request.Method = Method;
            request.RequestUri = new Uri(fullUri);
            request.Headers.Add("UserAgent", UserAgentHelper.GetRandomUserAgent(UserAgent));
            var cookies = option.Cookies.ToDictionary(t => t.Key, t => t.Value);
            foreach (var keyValuePair in Cookies)
            {
                cookies[keyValuePair.Key] = keyValuePair.Value;
            }
            return Task.FromResult(request);
        }
    }

    public class GetSingleDiscussionRequest : RequestBase
    {
        public int DiscussionId { get; set; }
    }
    public class GetSingleDiscussionActualRequest : ActualRequestBase
    {
        public string DiscussionId { get; internal set; }
    }
    public class GetSingleDiscussionResponse : ResponseBase
    {
        [JsonPropertyName("data")] public DiscussionInfo? Discussion { get; set; }

        public class DiscussionInfo : FlarumDataBase
        {
            [JsonPropertyName("attributes")] public FlarumDiscussionDto FlarumDiscussion { get; set; }
            [JsonPropertyName("relationships")] public DiscussionRelationships Relationships { get; set; }

        }

        public class DiscussionRelationships : FlarumRelationshipsBase
        {
            //[JsonPropertyName("posts")] public StreamlinedPostsInfo[]? StreamlinedPostsInfos { get; set; }
        }

        public class StreamlinedPostsInfo : FlarumDataBase
        {

        }
    }
}
