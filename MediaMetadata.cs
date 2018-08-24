using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace Models
{
    public class MediaMetadata
    {
        public virtual string ContentType { get; set; }
        public virtual MediaType MediaType { get; set; }
    }
}
