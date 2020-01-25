using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savory.SentenceManage.Contract.Vo
{
    public abstract class SentenceVo
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("dataStatus")]
        public int? DataStatus { get; set; }

        [JsonProperty("createTime")]
        public DateTime? CreateTime { get; set; }

        [JsonProperty("lastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; }
    }
}
