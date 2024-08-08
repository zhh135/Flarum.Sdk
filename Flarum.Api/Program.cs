using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;

var handler = new FlarumApiHandler();
var options = new FlarumApiHandlerOption();
options.Url = "https://community.wvbtech.com/";
var result = await handler.RequestAsync<GetForumInfoRequest, GetForumInfoResponse, ErrorResultBase, GetForumInfoActualRequest>(new GetForumInfoApi(), options);
Console.WriteLine($"{result.IsSuccess}");

//Console.WriteLine($"title:{info.Title}");