using Flarum.Api;
using Flarum.Api.ApiContracts;
using Flarum.Api.Bases;
using System.Net.NetworkInformation;

var handler = new FlarumApiHandler();
var options = new FlarumApiHandlerOption();
options.Url = "https://community.wvbtech.com";
var result = await handler.RequestAsync<GetSingleDiscussionRequest, GetSingleDiscussionResponse, ErrorResultBase, GetSingleDiscussionActualRequest>(new GetSingleDiscussionApi(), new GetSingleDiscussionRequest() { DiscussionId = 2533},options);
var info = result.Match(
    success => success?.Discussion.FlarumDiscussion,
    error => new() { });
Console.WriteLine($"{info.Title}");


//Console.WriteLine($"{info.Description}");
//Console.WriteLine($"{info.WelcomeMessage}");
//Console.WriteLine($"title:{info.Title}");