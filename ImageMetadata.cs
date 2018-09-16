using System;

namespace Models
{
    public class ImageMetadata : FileMetadata
    {
        public override FileType FileType
        {
            get => base.FileType;
            set
            {
                if (value != FileType.Image)
                {
                    throw new InvalidOperationException();
                }
                base.FileType = value;
            }
        }

        public ImageMetadata()
        {

        }

        public ImageMetadata(FileMetadata value)
        {
            FileType = value.FileType;
            ContentType = value.ContentType;
        }
    }
}