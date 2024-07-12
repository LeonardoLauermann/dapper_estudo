using System.ComponentModel.DataAnnotations;
namespace estacionamento_dapper.Models;

public class Vaga
{
    [Key]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(50)]

    public string CodigoLocalizacao { get; set; } = default!;

    public bool Ocupada { get; set; } = default!;
}