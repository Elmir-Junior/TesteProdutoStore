using System.ComponentModel.DataAnnotations;

namespace TesteProdutoStore.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
