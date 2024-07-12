using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento_dapper.Models;

// Classe Veiculo
public class Veiculo
{
    [Key]
    public int Id { get; set; } = default!;

    [Required]
    [StringLength(50)]
    public string Placa { get; set; } = default!;

    [StringLength(100)]
    public string Modelo { get; set; } = default!;

    [StringLength(100)]
    public string Marca { get; set; } = default!;

    public int ClienteId { get; set; } = default!;

}
