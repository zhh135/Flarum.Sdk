using Kengwang.Toolkit;
using System.Text;
using System.Text.Json;

using Flarum.Api.Bases;
using Flarum.Api.Helpers;


namespace Flarum.Api.Bases
{
    public abstract class ApiBase<TActualRequest, TRequest, TResponse, TError>
        : ApiContractBase<TActualRequest, TRequest, TResponse, TError>
        where TActualRequest : ActualRequestBase
        where TRequest : RequestBase
        where TResponse : ResponseBase, new()
        where TError : ErrorResultBase
    {
        public override HttpMethod Method => null;

        public override string ApiPath => null;

        public override string? UserAgent => "pc";

        public override async Task<HttpRequestMessage> GenerateRequestMessageAsync(FlarumApiHandlerOption option)
        {
            return await GenerateRequestMessageAsync(ActualRequest!, option).ConfigureAwait(false);    
        }

        public override Task<HttpRequestMessage> GenerateRequestMessageAsync<TActualRequestModel>(TActualRequestModel actualRequest, FlarumApiHandlerOption option)
        {
            var request = new HttpRequestMessage();
            var fullUri = $"{option.Url}/{ApiPath}";
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

        public override Task MapRequest(TRequest? request)
        {
            return Task.CompletedTask;
        }

        public override async Task<Results<TResponse, ErrorResultBase>> ProcessResponseAsync(HttpResponseMessage response, FlarumApiHandlerOption option)
        {
            return await ProcessResponseAsync<TResponse>(response, option).ConfigureAwait(false);
        }

        public override async Task<Results<TResponseModel, ErrorResultBase>> ProcessResponseAsync<TResponseModel>(HttpResponseMessage response, FlarumApiHandlerOption option)
        {
            if (!response.IsSuccessStatusCode)
            {
                return new ErrorResultBase((int)response.StatusCode, $"请求返回 HTTP 代码: {response.StatusCode}");
            }

            var buffer = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            if (buffer is null || buffer.Length == 0) return new ErrorResultBase(500, "返回体预读取错误");

            var result = Encoding.UTF8.GetString(buffer);
            result = StringHelper.ConvertUnicodeToString(result);
            var ret = JsonSerializer.Deserialize<TResponseModel>(result, option.JsonSerializerOptions);

            if (ret is null) return new ErrorResultBase(500, "返回 JSON 解析为空");
            if (ret is CodedResponseBase codedResponseBase && codedResponseBase.Code != 200)
                return Results<TResponseModel, ErrorResultBase>
                       .CreateError(new ErrorResultBase(codedResponseBase.Code, "返回值不为 200")).WithValue(ret);
            return ret;
        }
    }
}
