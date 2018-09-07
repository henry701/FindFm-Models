﻿using System;

namespace Models
{
    public class ImageMetadata : MediaMetadata
    {
        public override MediaType MediaType
        {
            get => base.MediaType;
            set
            {
                if (value != MediaType.Image)
                {
                    throw new InvalidOperationException();
                }
                base.MediaType = value;
            }
        }

        public ImageMetadata()
        {

        }

        public ImageMetadata(MediaMetadata value)
        {
            MediaType = value.MediaType;
            ContentType = value.ContentType;
        }
    }
}