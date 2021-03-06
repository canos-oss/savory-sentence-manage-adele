using Savory.SentenceManage.Contract.Vo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savory.SentenceManage.Contract.Response
{
    public class SentenceItemsResponse : BaseResponse
    {
        [JsonProperty("items")]
        public List<SentenceExtendedVo> Items { get; set; }
    }
}
