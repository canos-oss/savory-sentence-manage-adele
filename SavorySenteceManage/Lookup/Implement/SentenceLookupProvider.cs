using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savory.SentenceManage.Lookup.Implement
{
    public class SentenceLookupProvider : ISentenceLookupProvider
    {
        public List<Header> Headers { get; private set; }

        public SentenceLookupProvider()
        {
            Headers = new List<Header>();

            Headers.Add(new Header { Text = "编号", Value = "id" });
            Headers.Add(new Header { Text = "内容", Value = "content" });
            Headers.Add(new Header { Text = "创建时间", Value = "createTime" });
            Headers.Add(new Header { Text = "最后更新时间", Value = "lastUpdateTime" });
        }
    }
}
