using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace estacionamento_dapper.Models;

public class Ticket
{
    [Key]
    public int Id { get; set; } = default!;

    public DateTime DataEntrada { get; set; } = default!;

    public DateTime? DataSaida { get; set; }

    public float Valor { get; set; } = default!;

    [ForeignKey("VeiculoId")]
    public int VeiculoId { get; set; } = default!;

    [ForeignKey("VagaId")]
    public int VagaId { get; set; } = default!;

}