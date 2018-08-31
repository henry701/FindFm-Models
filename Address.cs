using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Address : BaseEntity<string>
    {
        [Display(Name = "Tipo de Bairro")]
        public DistrictKind DistrictKind { get; set; }
        [Display(Name = "Estado")]
        public BrazilState State { get; set; }
        [Display(Name = "CEP")]
        public string ZipCode { get; set; }
        [Display(Name = "Logradouro")]
        public string Road { get; set; }
        [Display(Name = "Número")]
        public string Numeration { get; set; }
        [Display(Name = "Cidade")]
        public string City { get; set; }
    }
}