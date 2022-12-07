using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseCrimes.Models
{
    [Table("Cadastro")]
    public class Usuario
    {
        [Column("UsuarioId")][Key]
        [Display(Name = "UsuarioId")]
        public int usuarioId { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "UsuarioNome")]
        public string? usuarioNome { get; set; }

        [Column("UsuarioSobrenome")]
        [Display(Name = "UsuarioSobrenome")]
        public string? usuarioSobrenome { get; set; }

        [Column("UsuarioDtnascimento")]
        [Display(Name = "UsuarioDtnascimento")]
        public string? usuarioDtnascimento { get; set; }

        [Column("UsuarioTelefone")]
        [Display(Name = "UsuarioTelefone")]
        public string? usuarioTelefone { get; set; }

        [Column("UsuarioEmail")]
        [Display(Name = "UsuarioEmail")]
        public string? usuarioEmail { get; set; }

        [Column("UsuarioNickname")]
        [Display(Name = "UsuarioNickname")]
        public string? usuarioNickname { get; set; }

        [Column("UsuarioPassword")]
        [Display(Name = "UsuarioPassword")]
        public string? usuarioPassword { get; set; }

        [Column("UsuarioTipo")]
        [Display(Name = "UsuarioTipo")]
        public string? usuarioTipo { get; set; }
    }
}
