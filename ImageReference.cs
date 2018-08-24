using System;

namespace Models
{
    public class ImageReference : MediaReference
    {
        public override MediaMetadata MediaMetadata { get => base.MediaMetadata; set => base.MediaMetadata = new ImageMetadata(value); }
    }
}