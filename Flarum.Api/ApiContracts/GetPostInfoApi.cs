using Flarum.Api.Bases;
using Flarum.Api.Bases.ModelBases;
using Flarum.Api.Helpers;
using Flarum.Api.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.ApiContracts
{
    public class GetPostInfoApi :
        ApiBase<GetPostInfoActualRequest, GetPostInfoRequest, GetPostInfoResponse, ErrorResultBase>
    {
        public override string ApiPath => "/api/posts";
        public override HttpMethod Method => HttpMethod.Get;

        public override Task MapRequest(GetPostInfoRequest? request)
        {
            ActualRequest = new()
            {
                PostId = request.PostId.ToString(),
            };
            return Task.CompletedTask;
        }

        public override Task<HttpRequestMessage> GenerateRequestMessageAsync<TActualRequestModel>(TActualRequestModel actualRequest, FlarumApiHandlerOption option)
        {
            var request = new HttpRequestMessage();
            var req = actualRequest as GetPostInfoActualRequest ?? new GetPostInfoActualRequest();
            var fullUri = $"{option.Url}{ApiPath}/{req.PostId}";
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

    public class GetPostInfoActualRequest : ActualRequestBase
    {
        public string PostId { get; set; }
    }

    public class GetPostInfoRequest : RequestBase
    {
        public int PostId { get; set; }
    }

    public class GetPostInfoResponse : ResponseBase
    {
        [JsonPropertyName("data")] public ForumData Data { get; set; }

        public class ForumData : FlarumDataBase
        {
            [JsonPropertyName("attributes")] public FlarumPostDto Post { get; set; }
        }

    }
}
