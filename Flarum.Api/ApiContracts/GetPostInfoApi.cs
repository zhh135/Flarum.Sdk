using Flarum.Api.Bases;
using Flarum.Api.Bases.ModelBases;
using Flarum.Api.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.ApiContracts
{
    public class GetPostInfoApi :
        ApiBase<GetForumInfoActualRequest, GetForumInfoRequest, GetForumInfoResponse, ErrorResultBase>
    {
        public override string ApiPath => "/api";
        public override HttpMethod Method => HttpMethod.Get;

        public override Task MapRequest(GetForumInfoRequest? request)
        {
            return Task.CompletedTask;
        }
    }

    public class GetPostInfoActualRequest : ActualRequestBase
    {

    }

    public class GetPostInfoRequest : RequestBase
    {

    }

    public class GetInfoResponse : ResponseBase
    {
        [JsonPropertyName("data")] public ForumData Data { get; set; }

        public class ForumData : FlarumDataBase
        {
            [JsonPropertyName("attributes")] public FlarumForumDto flarumForum { get; set; }
        }

    }
}
