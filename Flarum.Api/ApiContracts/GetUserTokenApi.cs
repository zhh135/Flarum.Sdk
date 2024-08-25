using Flarum.Api.Bases;
using Flarum.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.ApiContracts
{
    public class GetUserTokenApi :
       ApiBase<GetUserTokenActualRequest, GetUserTokenRequest, GetUserTokenResponse, ErrorResultBase>
    {
        public override string ApiPath => "/api/users";
        public override HttpMethod Method => HttpMethod.Get;

        public override Task MapRequest(GetUserTokenRequest? request)
        {
            ActualRequest = new()
            {
                Identification = request.Identification,
                Password = request.Password
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
            string json = JsonSerializer.Serialize(actualRequest, option.JsonSerializerOptions);
            request.Content = new StringContent(json);
            var cookies = option.Cookies.ToDictionary(t => t.Key, t => t.Value);
            foreach (var keyValuePair in Cookies)
            {
                cookies[keyValuePair.Key] = keyValuePair.Value;
            }
            return Task.FromResult(request);
        }
    }

    public class GetUserTokenActualRequest : ActualRequestBase
    {
        public string Identification { get; set; }
        public string Password { get; set; }
    }

    public class GetUserTokenRequest : RequestBase
    {
        [JsonPropertyName("identification")] public string Identification { get; set; }
        [JsonPropertyName("password")] public string Password { get; set; }
    }

    public class GetUserTokenResponse : ResponseBase
    {
        [JsonPropertyName("token")] public string Token { get; set; }
        [JsonPropertyName("userId")] public string UserId { get; set; }
    }
}
