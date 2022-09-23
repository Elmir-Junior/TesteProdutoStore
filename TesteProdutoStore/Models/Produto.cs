using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteProdutoStore.Models.Base;

namespace TesteProdutoStore.Models
{
    [Table("tblProduto")]
    public class Produto : BaseEntity
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        public bool Ativo { get; set; } = true;
        public bool Perecivel { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
