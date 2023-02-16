using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEntity.Models
{
    [Table("TB_ALUNOS")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        public string NomeSocial { get; set; }

        [MaxLength(100)]
        public string Endereco { get; set; }

        public int TipoId { get; set; }

        public virtual Tipo Tipo { get; set; }
    }
}
