using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Flarum.Api.Bases;
using Kengwang.Toolkit;

namespace Flarum.Api
{
    public class FlarumApiHandler
    {
        private readonly HttpClientHandler _httpClientHandler =
        new()
        {
            UseCookies = false,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
        };

        public void UseProxyConfiguration(bool useProxy, IWebProxy proxy)
        {
            _httpClientHandler.UseProxy = useProxy;
            _httpClientHandler.Proxy = proxy;
        }

        public async Task<Results<TResponse, ErrorResultBase>> RequestAsync<TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, FlarumApiHandlerOption option)
        where TError : ErrorResultBase where TActualRequest : ActualRequestBase where TRequest : RequestBase where TResponse : ResponseBase, new()
        {
            var client = new HttpClient(_httpClientHandler);
            var response = await client.SendAsync(await contract.GenerateRequestMessageAsync(option)).ConfigureAwait(false);
            return await contract.ProcessResponseAsync(response, option).ConfigureAwait(false);
        }

        public async Task<Results<TResponse, ErrorResultBase>> RequestAsync<TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, TRequest? request,
            FlarumApiHandlerOption option, CancellationToken cancellationToken = default)
            where TError : ErrorResultBase where TActualRequest : ActualRequestBase where TRequest : RequestBase where TResponse : ResponseBase, new()
        {
            var client = new HttpClient(_httpClientHandler);
            contract.Request = request;
            await contract.MapRequest(request).ConfigureAwait(false);
            var response = await client.SendAsync(await contract.GenerateRequestMessageAsync(option).ConfigureAwait(false), cancellationToken).ConfigureAwait(false);
            return await contract.ProcessResponseAsync(response, option).ConfigureAwait(false);
        }

        public async Task<Results<TCustomResponse, ErrorResultBase>> RequestAsync<TCustomResponse, TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, TRequest? request,
            FlarumApiHandlerOption option, CancellationToken cancellationToken = default)
            where TError : ErrorResultBase where TActualRequest : ActualRequestBase where TRequest : RequestBase where TCustomResponse : ResponseBase, new() where TResponse : ResponseBase, new()
        {
            var client = new HttpClient(_httpClientHandler);
            contract.Request = request;
            await contract.MapRequest(request).ConfigureAwait(false);
            var response = await client.SendAsync(await contract.GenerateRequestMessageAsync(option).ConfigureAwait(false)).ConfigureAwait(false);
            return await contract.ProcessResponseAsync<TCustomResponse>(response, option).ConfigureAwait(false);
        }

        public async Task<Results<TCustomResponse, ErrorResultBase>> RequestAsync<TCustomRequest, TCustomResponse, TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, bool differ, TCustomRequest? request,
            FlarumApiHandlerOption option, CancellationToken cancellationToken = default)
            where TError : ErrorResultBase where TActualRequest : ActualRequestBase where TRequest : RequestBase where TResponse : ResponseBase, new() where TCustomResponse : ResponseBase, new()
        {
            var client = new HttpClient(_httpClientHandler);
            var response = await client.SendAsync(await contract.GenerateRequestMessageAsync<TCustomRequest>(request!, option).ConfigureAwait(false)).ConfigureAwait(false);
            return await contract.ProcessResponseAsync<TCustomResponse>(response, option).ConfigureAwait(false);
        }

        public async Task<Results<TResponse, ErrorResultBase>> RequestAsync<TCustomRequest, TRequest, TResponse, TError, TActualRequest>(
            ApiContractBase<TActualRequest, TRequest, TResponse, TError> contract, bool differ, TCustomRequest? request,
            FlarumApiHandlerOption option, CancellationToken cancellationToken = default)
            where TError : ErrorResultBase where TActualRequest : ActualRequestBase where TRequest : RequestBase where TResponse : ResponseBase, new()
        {
            var client = new HttpClient(_httpClientHandler);
            var response = await client.SendAsync(await contract.GenerateRequestMessageAsync<TCustomRequest>(request!, option)).ConfigureAwait(false);
            return await contract.ProcessResponseAsync(response, option).ConfigureAwait(false);
        }
    }

}

