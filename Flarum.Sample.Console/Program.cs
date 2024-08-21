using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;
using System.Net.NetworkInformation;

var handler = new FlarumApiHandler();
var options = new FlarumApiHandlerOption();
options.Url = "https://community.wvbtech.com";
var result = await handler.RequestAsync<GetPostInfoRequest, GetPostInfoResponse, ErrorResultBase, GetPostInfoActualRequest>(new GetPostInfoApi(), new GetPostInfoRequest() { PostId = 48194},options);
var info = result.Match(
    success => success?.Data.Post,
    error => new() { });
Console.WriteLine($"{info.ContentType}");


//Console.WriteLine($"{info.Description}");
//Console.WriteLine($"{info.WelcomeMessage}");
//Console.WriteLine($"title:{info.Title}");