using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum PremiumLevel : int
    {
        [Display(Name = "Nenhum")]
        None = 0,
        [Display(Name = "Básico")]
        Basic = 1,
        [Display(Name = "Intermediário")]
        Intermediary = 2,
        [Display(Name = "Full")]
        Full = 3
    }
}
