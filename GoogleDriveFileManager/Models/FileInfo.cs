using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleDriveFileManager.Models
{
    public class FileInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public long? size { get; set; }
        public long? version { get; set; }
        public DateTime? createdTime { get; set; }
    }
}