using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Savory.SentenceManage.Contract.Vo;

namespace Savory.SentenceManage.Contract.Request
{
    /// <summary>
    /// 根据id(或主属性)更新单个句子
    /// </summary>
    public class SentenceUpdateRequest
    {
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// item
        /// </summary>
        [JsonProperty("item")]
        public SentenceBasicVo Item { get; set; }
    }
}
