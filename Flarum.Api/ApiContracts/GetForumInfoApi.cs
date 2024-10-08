﻿using System.Text.Json.Serialization;
using Flarum.Api.Bases;
using Flarum.Api.Bases.ModelBases;
using Flarum.Api.Models.ResponseModel;


namespace Flarum.Api.ApiContracts
{
    public class GetForumInfoApi : 
        ApiBase<GetForumInfoActualRequest, GetForumInfoRequest, GetForumInfoResponse, ErrorResultBase>
    {
        public override string ApiPath => "/api";
        public override HttpMethod Method => HttpMethod.Get;

        public override Task MapRequest(GetForumInfoRequest? request)
        {
            return Task.CompletedTask;
        }
    }

    public class GetForumInfoActualRequest : ActualRequestBase
    {

    }

    public class GetForumInfoRequest : RequestBase
    {
        
    }

    public class GetForumInfoResponse : ResponseBase
    {
        [JsonPropertyName("data")] public ForumData Data { get; set; }

        public class ForumData : FlarumDataBase
        {
            [JsonPropertyName("attributes")] public FlarumForumDto flarumForum { get; set; }
        }
        
    }
}
