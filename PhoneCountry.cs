using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum PhoneCountry : int
    {
        [Display(Name = "Brasil", ShortName = "BR")]
        Brazil = 55
    }
}