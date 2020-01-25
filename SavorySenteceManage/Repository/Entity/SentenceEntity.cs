using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savory.SentenceManage.Repository.Entity
{

    public class SentenceEntity
    {

        public int Id { get; set; }

        public string Content { get; set; }

        public int DataStatus { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}
