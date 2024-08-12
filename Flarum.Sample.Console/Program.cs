using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;

var handler = new FlarumApiHandler();
var options = new FlarumApiHandlerOption();
options.Url = "https://community.wvbtech.com/";
var result = await handler.RequestAsync<GetForumInfoRequest, GetForumInfoResponse, ErrorResultBase, GetForumInfoActualRequest>(new GetForumInfoApi(), options);
var info = result.Match(
    success => success?.Data.flarumForum,
    error => new() { });
Console.WriteLine($"{info.Title}");
Console.WriteLine($"{info.Description}");
Console.WriteLine($"{info.WelcomeMessage}");
//Console.WriteLine($"title:{info.Title}");