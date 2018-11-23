using System.Collections.Generic;

namespace Models
{
    public class Work : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Original { get; set; }
        public IList<FileReference> FileReferences { get; set; }
        public IList<Song> Songs { get; set; }
        public IList<User> RelatedMusicians { get; set; }
    }
}