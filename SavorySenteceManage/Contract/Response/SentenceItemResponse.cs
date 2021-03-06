using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Savory.SentenceManage.Contract.Vo;

namespace Savory.SentenceManage.Contract.Response
{
    public class SentenceItemResponse : BaseResponse
    {
        [JsonProperty("item")]
        public SentenceExtendedVo Item { get; set; }
    }
}
