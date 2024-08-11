using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;

var handler = new FlarumApiHandler();
var options = new FlarumApiHandlerOption();
options.Url = "https://discuss.flarum.org/";
var result = await handler.RequestAsync<GetForumInfoRequest, GetForumInfoResponse, ErrorResultBase, GetForumInfoActualRequest>(new GetForumInfoApi(), options);
var info = result.Match(
    success => success?.Data.flarumForum,
    error => new() { });
Console.WriteLine($"{info.Title}");

//Console.WriteLine($"title:{info.Title}");