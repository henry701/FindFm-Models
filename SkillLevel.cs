using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum SkillLevel : int
    {
        [Display(Name = "Nenhum")]
        None = 0,
        [Display(Name = "Iniciante")]
        Beginner = 1,
        [Display(Name = "Intermediário")]
        Intermediary = 2,
        [Display(Name = "Avançado")]
        Advanced = 3
    }
}
