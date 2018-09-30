using System;

namespace Models
{
    public class AudioMetadata : FileMetadata
    {
        public override FileType FileType
        {
            get => base.FileType;
            set
            {
                if (value != FileType.Audio)
                {
                    throw new InvalidOperationException();
                }
                base.FileType = value;
            }
        }

        public AudioMetadata()
        {

        }

        public AudioMetadata(FileMetadata value)
        {
            FileType = value.FileType;
            ContentType = value.ContentType;
        }
    }
}