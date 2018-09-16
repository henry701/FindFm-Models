using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum FileType : int
    {
        [Display(Name = "Imagem")]
        Image = 0,
        [Display(Name = "Vídeo")]
        Video = 1,
        [Display(Name = "Música")]
        Audio = 2,
    }
}