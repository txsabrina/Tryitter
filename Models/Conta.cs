using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tryitter.Models
{

  [Table("Contas")]
  public class Conta
  {
    public Conta()
    {
      Postagens = new Collection<Postagem>();
    }

    [Key]
    public int ContaId { get; set; }
    [Required]
    [StringLength(50)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(50)]
    public string? Email { get; set; }
    [Required]
    [StringLength(50)]
    public string? Modulo { get; set; }
    public string? Status { get; set; }
    [Required]
    [StringLength(10)]
    public string? Senha { get; set; }
    public ICollection<Postagem>? Postagens { get; set; }
  }
}