using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public abstract record ProductForManipulationDto
    {
        [Required(ErrorMessage = "O nome do produto é um campo obrigatório.")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo para o nome é de 100 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A descrição do produto é um campo obrigatório.")]
        public string? Description { get; set; }

        [Range(1, Double.MaxValue,
            ErrorMessage = "O preço do produto é um campo obrigatório e não pode ser igual a zero.")]
        public Decimal Price { get; set; }
        public Boolean Active { get; set; }
        public Guid UserUpdate { get; set; }
    }
}
