using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record CompanyForCreationDto()
    {
        [Required(ErrorMessage = "O nome da empresa é um campo obrigatório.")]
        [MaxLength(30, ErrorMessage = "O tamanho máximo para o nome da empresa é de 100 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O nome comercial da empresa é um campo obrigatório.")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo para o nome comercial da emprea é de 100 caracteres.")]
        public string? CommercialName { get; set; }
        public string? Cnpj { get; set; }
        public string? contact { get; set; }
        public string? Ddd { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Neighborhood { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? Uf { get; set; }
        public string? Zipcode { get; set; }
        public Boolean Active { get; set; }
        public Guid UserUpdate { get; set; }
    }
}
