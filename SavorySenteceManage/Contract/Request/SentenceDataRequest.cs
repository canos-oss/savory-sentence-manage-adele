using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savory.SentenceManage.Contract.Request
{
    public class SentenceDataRequest : SentenceCountRequest
    {
        public int? PageIndex { get; set; }
    }
}
