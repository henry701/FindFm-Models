namespace Models
{
    [RootEntity]
    public class Advertisement : BaseEntity
    {
        public Contractor Poster { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public FileReference FileReference { get; set; }
    }
}
