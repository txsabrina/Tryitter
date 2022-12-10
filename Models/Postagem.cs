using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tryitter.Models
{

  [Table("Postagens")]
  public class Postagem
  {
    [Key]
    public int PostagemId { get; set; }
    [StringLength(300)]
    public string? Texto { get; set; }
    public string? Imagem { get; set; }
    public DateTime DataPostagem { get; set; }
    public int ContaId { get; set; }
    //[JsonIgnore]
    public Conta? Conta { get; set; }
  }
}