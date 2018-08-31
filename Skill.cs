using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum Skill : int
    {
        DEFAULT = 0,
        [Display(Name = "Violão")]
        Guitar = 1,
        [Display(Name = "Bateria")]
        Drums = 2,
        [Display(Name = "Baixo")]
        Bass = 3,
        [Display(Name = "Canto")]
        Vocal = 4,
        [Display(Name = "Saxofone")]
        Saxophone = 5,
        [Display(Name = "Piano")]
        Piano = 6,
        [Display(Name = "Percussão")]
        Percussion = 7,
        [Display(Name = "Trombone")]
        Trombone = 8,
        [Display(Name = "Violino")]
        Violin = 9,
        [Display(Name = "Guitarra")]
        ElectricGuitar = 10,
        [Display(Name = "Flauta")]
        Flute = 11
    }
}