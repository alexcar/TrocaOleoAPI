using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Company : Entity
    {
        /*
         * [Required(ErrorMessage = "O nome da empresa é um campo obrigatório.")]
            [MaxLength(60, ErrorMessage = "O comprimento máximo do nome é de 60 caracteres.")] 
            [Required(ErrorMessage = "O nome fantasia é um campo obrigatório.")]
            [MaxLength(60, ErrorMessage = "O comprimento máximo do nome é de 60 caracteres.")]
            [Required(ErrorMessage = "O número CNPJ é um campo obrigatório.")]
            [Required(ErrorMessage = "O nome de contato é um campo obrigatório.")]
            [MaxLength(50, ErrorMessage = "O comprimento máximo do nome é de 50 caracteres.")]
            [Required(ErrorMessage = "O número de DDD é um campo obrigatório.")]
         * [Required(ErrorMessage = "O número de telefone é um campo obrigatório.")]
         * [MaxLength(90, ErrorMessage = "O comprimento máximo do nome é de 90 caracteres.")]
         * [Required(ErrorMessage = "O email é um campo obrigatório.")]
        [MaxLength(90, ErrorMessage = "O comprimento máximo do nome é de 90 caracteres.")]
        [Required(ErrorMessage = "O endereço é um campo obrigatório.")]
        [MaxLength(60, ErrorMessage = "O comprimento máximo do endereço é de 60 caracteres.")]
        [Required(ErrorMessage = "O bairro é um campo obrigatório.")]
        [MaxLength(60, ErrorMessage = "O comprimento máximo do endereço é de 60 caracteres.")]
        [Required(ErrorMessage = "O município é um campo obrigatório.")]
        [MaxLength(60, ErrorMessage = "O comprimento máximo do endereço é de 60 caracteres.")]
        [Required(ErrorMessage = "O município é um campo obrigatório.")]
        [MaxLength(60, ErrorMessage = "O comprimento máximo do endereço é de 60 caracteres.")]
        [Required(ErrorMessage = "O estado é um campo obrigatório.")]
        [Required(ErrorMessage = "O CEP é um campo obrigatório.")]
         * 
         */
        
        public string? Name { get; set; }        
        public string? CommercialName { get; set; }        
        public string? Cnpj { get; set; }        
        public string? Contact { get; set; }        
        public string? Ddd { get; set; }        
        public string? Phone { get; set; }        
        public string? WebSite { get; set; }        
        public string? Email { get; set; }        
        public string? Address { get; set; }        
        public string? Neighborhood { get; set; }        
        public string? County { get; set; }        
        public string? Country { get; set; }        
        public string? UF { get; set; }        
        public string? ZipCode { get; set; }        
        
        public ICollection<Infrastructure>? Infrastructures { get; set; } = new List<Infrastructure>();
    }
}
