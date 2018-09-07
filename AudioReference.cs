namespace Models
{
    public class AudioReference : MediaReference
    {
        public override MediaMetadata MediaMetadata { get => base.MediaMetadata; set => base.MediaMetadata = new AudioMetadata(value); }
    }
}