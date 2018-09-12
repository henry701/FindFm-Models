using System.ComponentModel.DataAnnotations;

namespace Models
{
    public enum BrazilState : int
    {
        [Display(Name = "Rondônia", ShortName = "RO")]
        RO = 11,
        [Display(Name = "Acre", ShortName = "AC")]
        AC = 12,
        [Display(Name = "Amazonas", ShortName = "AM")]
        AM = 13,
        [Display(Name = "Roraima", ShortName = "RR")]
        RR = 14,
        [Display(Name = "Pará", ShortName = "PA")]
        PA = 15,
        [Display(Name = "Amapá", ShortName = "AP")]
        AP = 16,
        [Display(Name = "Tocantins", ShortName = "TO")]
        TO = 17,
        [Display(Name = "Maranhão", ShortName = "MA")]
        MA = 21,
        [Display(Name = "Piauí", ShortName = "PI")]
        PI = 22,
        [Display(Name = "Ceará", ShortName = "CE")]
        CE = 23,
        [Display(Name = "Rio Grande do Norte", ShortName = "RN")]
        RN = 24,
        [Display(Name = "Paraíba", ShortName = "PB")]
        PB = 25,
        [Display(Name = "Pernambuco", ShortName = "PE")]
        PE = 26,
        [Display(Name = "Alagoas", ShortName = "AL")]
        AL = 27,
        [Display(Name = "Sergipe", ShortName = "SE")]
        SE = 28,
        [Display(Name = "Bahia", ShortName = "BA")]
        BA = 29,
        [Display(Name = "Minas Gerais", ShortName = "MG")]
        MG = 31,
        [Display(Name = "Espírito Santo", ShortName = "ES")]
        ES = 32,
        [Display(Name = "Rio de Janeiro", ShortName = "RJ")]
        RJ = 33,
        [Display(Name = "São Paulo", ShortName = "SP")]
        SP = 35,
        [Display(Name = "Paraná", ShortName = "PR")]
        PR = 41,
        [Display(Name = "Santa Catarina", ShortName = "SC")]
        SC = 42,
        [Display(Name = "Rio Grande do Sul", ShortName = "RS")]
        RS = 43,
        [Display(Name = "Mato Grosso do Sul", ShortName = "MS")]
        MS = 50,
        [Display(Name = "Mato Grosso", ShortName = "MT")]
        MT = 51,
        [Display(Name = "Goiás", ShortName = "GO")]
        GO = 52,
        [Display(Name = "Distrito Federal", ShortName = "DF")]
        DF = 53
    }
}

