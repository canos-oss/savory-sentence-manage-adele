using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savory.SentenceManage.Lookup
{
    public interface ISentenceLookupProvider
    {
        List<Header> Headers { get; }
    }
}
