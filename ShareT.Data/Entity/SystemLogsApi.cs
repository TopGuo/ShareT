using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class SystemLogsApi
    {
        public int Id { get; set; }
        public string ApiName { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public bool? Success { get; set; }
        public string Source { get; set; }
        public string Ip { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UserAgent { get; set; }
        public int? AccountId { get; set; }
    }
}
