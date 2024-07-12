using System.ComponentModel.DataAnnotations;

namespace estacionamento_dapper.Models;

public class Valores
{
    [Key]
    public int Id { get; set; }

    public int Minutos { get; set; }

    public float ValorMinuto { get; set; }
}