using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Savory.SentenceManage.Contract.Request
{
    /// <summary>
    /// 根据id(或主属性)获取单个句子
    /// </summary>
    public class SentenceItemRequest
    {
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
