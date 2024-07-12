using System.ComponentModel.DataAnnotations;

namespace estacionamento_dapper.Models;
public class Cliente
{
    [Key]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(100)]
    public string? Nome { get; set; }

    [StringLength(20)]
    public string? CPF { get; set; }

    // Relacionamento com Tickets
    public ICollection<Ticket>? Tickets { get; set; } 
}
