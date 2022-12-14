using System.ComponentModel.DataAnnotations;

namespace NotasLibres.Models
{
  public class Nota
  {
    [Key]
    public uint NotasId { get; set; }
    public string? Titulo { get; set; }
    public string? Contenido { get; set; }
    public DateTime Creacion { get; set; }
    public DateTime Modificacion { get; set; }
  }
}