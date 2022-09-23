using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TesteProdutoStore.Models.Base;

namespace TesteProdutoStore.Models
{
    [Table("tblCategoriaProduto")]
    public class Categoria:BaseEntity
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
