using System.ComponentModel.DataAnnotations;

namespace WebUsinagem.Models
{
    public class Registro
    {
        public int Id { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public string CodigoBP { get; set; }
        [Required]
        public string? DescricaoNaoConformidade { get; set; }
        public string? OpcaoRetrabalhoFabricar { get; set; }
        public string? OrigemRetrabalho { get; set; }
        public string? Fornecedor { get; set; }
        public string? Projeto { get; set; }
        public string? OpcaoFabricacao { get; set; }
        public DateTime? DataFabricacao { get; set; }
        [Required]
        public string NomeSolicitante { get; set; }
    }
}
