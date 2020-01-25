using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Savory.SentenceManage.Contract.Vo;

namespace Savory.SentenceManage.Contract.Request
{
    public class SentenceCreateRequest
    {

        [JsonProperty("item")]
        public SentenceBasicVo Item { get; set; }
    }
}
