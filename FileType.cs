using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum FileType : int
    {
        [Display(Name = "Imagem", ShortName = "img")]
        Image = 0,
        [Display(Name = "Vídeo", ShortName = "vid")]
        Video = 1,
        [Display(Name = "Música", ShortName = "mus")]
        Audio = 2,
    }
}