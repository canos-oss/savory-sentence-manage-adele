using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Savory.SentenceManage.Contract.Vo;
using Savory.SentenceManage.Lookup;

namespace Savory.SentenceManage.Contract.Response
{
    public class SentenceDataResponse : BaseResponse
    {
        [JsonProperty("headers")]
        public List<Header> Headers { get; set; }

        [JsonProperty("items")]
        public List<SentenceExtendedVo> Items { get; set; }
    }
}
