using System.Collections.Generic;

namespace Models
{
    public class Work : BaseEntity
    {
        public string Name { get; set; }
        public bool Original { get; set; }
        public ISet<FileReference> FileReferences { get; set; }
    }
}