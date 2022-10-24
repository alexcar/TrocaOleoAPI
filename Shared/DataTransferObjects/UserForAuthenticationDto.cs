using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Uma senha é obrigatório.")]
        public string? Password { get; init; }
    }
}
