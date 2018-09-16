namespace Models
{
    public class AudioReference : FileReference
    {
        public override FileMetadata FileMetadata { get => base.FileMetadata; set => base.FileMetadata = new AudioMetadata(value); }
    }
}