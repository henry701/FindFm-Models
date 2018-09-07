using System;

namespace Models
{
    internal class AudioMetadata : MediaMetadata
    {
        public override MediaType MediaType
        {
            get => base.MediaType;
            set
            {
                if (value != MediaType.Audio)
                {
                    throw new InvalidOperationException();
                }
                base.MediaType = value;
            }
        }

        public AudioMetadata()
        {

        }

        public AudioMetadata(MediaMetadata value)
        {
            MediaType = value.MediaType;
            ContentType = value.ContentType;
        }
    }
}