using System.ComponentModel.DataAnnotations;

namespace MVCEntity.Models
{
    public class Tipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public bool AcessoAndares { get; set; }

    }
}
