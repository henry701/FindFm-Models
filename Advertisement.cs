using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [RootEntity]
    public class Advertisement : BaseEntity
    {
        public Contractor Poster { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public MediaReference MediaReference { get; set; }
    }
}
