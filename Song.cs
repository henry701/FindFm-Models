namespace Models
{
    public class Song : BaseEntity
    {
        public string Name { get; set; }
        public AudioReference AudioReference { get; set; }

        public bool Original { get; set; }
        public bool RadioAuthorized { get; set; }

        public uint DurationSeconds { get; set; }

        public uint TimesPlayed { get; set; }
        public uint TimesPlayedRadio { get; set; }
    }
}