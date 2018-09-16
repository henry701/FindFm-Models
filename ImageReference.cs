namespace Models
{
    public class ImageReference : FileReference
    {
        public override FileMetadata FileMetadata { get => base.FileMetadata; set => base.FileMetadata = new ImageMetadata(value); }
    }
}