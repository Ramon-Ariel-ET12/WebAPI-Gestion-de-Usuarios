using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApi.Domain.Entities;

[Table("UsuarioRol")]
public class UsuarioRol
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUsuarioRol { get; set; }

    [Required]
    [ForeignKey("IdUsuario")]
    public Usuario? Usuario { get; set; }

    [Required]
    [ForeignKey("IdRol")]
    public Rol? Rol { get; set; }

    public UsuarioRol() { }

    public UsuarioRol(Usuario usuario, Rol rol)
    {
        Usuario = usuario;
        Rol = rol;
    }
}