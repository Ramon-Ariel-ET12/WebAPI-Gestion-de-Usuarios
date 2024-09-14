using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApi.Domain.Entities;

[Table("Rol")]
public class Rol
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRol { get; set; }
    [Required]
    [StringLength(50)]
    public string? Nombre { get; set; }
    [Required]
    public bool Habilitado { get; set; }
    [Required]
    public DateTime FechaCreacion { get; set; }

    public Rol() { }

    public Rol(string nombre, bool habilitado, DateTime fechaCreacion)
    {
        Nombre = nombre;
        Habilitado = habilitado;
        FechaCreacion = fechaCreacion;
    }
}