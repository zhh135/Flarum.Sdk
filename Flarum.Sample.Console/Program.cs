using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;
using System.Net.NetworkInformation;

var handler = new FlarumApiHandler();
var options = new FlarumApiHandlerOption();
options.Url = "https://community.wvbtech.com/";
var result = await handler.RequestAsync<GetAllDiscussionsRequest, GetAllDiscussionsResponse, ErrorResultBase, GetAllDiscussionsActualRequest>(new GetAllDiscussionsApi(), options);
var info = result.Match(
    success => success?.Discussions.ToList(),
    error => new() { });
Console.WriteLine($"{info[0].FlarumDiscussion.Title}");
//Console.WriteLine($"{info.Description}");
//Console.WriteLine($"{info.WelcomeMessage}");
//Console.WriteLine($"title:{info.Title}");