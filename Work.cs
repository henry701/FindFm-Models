namespace Models
{
    public class Work : BaseEntity
    {
        public string Name { get; set; }
        public bool Original { get; set; }
        public MediaReference MediaReference { get; set; }
    }
}