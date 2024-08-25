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
    public class GetUserInfoApi :
        ApiBase<GetUserInfoActualRequest, GetUserInfoRequest, GetUserInfoResponse, ErrorResultBase>
    {
        public override string ApiPath => "/api/users";
        public override HttpMethod Method => HttpMethod.Get;

        public override Task MapRequest(GetUserInfoRequest? request)
        {
            ActualRequest = new()
            {
                UserId = request.UserId.ToString(),
            };
            return Task.CompletedTask;
        }

        public override Task<HttpRequestMessage> GenerateRequestMessageAsync<TActualRequestModel>(TActualRequestModel actualRequest, FlarumApiHandlerOption option)
        {
            var request = new HttpRequestMessage();
            var req = actualRequest as GetUserInfoActualRequest ?? new GetUserInfoActualRequest();
            var fullUri = $"{option.Url}{ApiPath}/{req.UserId}";
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

    public class GetUserInfoActualRequest : ActualRequestBase
    {
        public string UserId { get; set; }
    }

    public class GetUserInfoRequest : RequestBase
    {
        public int UserId { get; set; }
    }

    public class GetUserInfoResponse : ResponseBase
    {
        [JsonPropertyName("data")] public ForumData Data { get; set; }

        public class ForumData : FlarumDataBase
        {
            [JsonPropertyName("attributes")] public FlarumUserDto User { get; set; }
        }

    }
}
