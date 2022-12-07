using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseCrimes.Models
{
    [Table("Filme")]
    public class Filme
    {
        [Column("FilmeId")]
        [Display(Name = "FilmeId")]
        public int filmeId { get; set; }

        [Column("FilmeTitulo")]
        [Display(Name = "FilmeTitulo")]
        public string? titulo { get; set; }

        [Column("FilmeDescricao")]
        [Display(Name = "FilmeDescricao")]
        public string? descricao { get; set; }

        [Column("FilmeClassificacao")]
        [Display(Name = "FilmeClassificacao")]
        public string? classificacao { get; set; }

        [Column("FilmeTipo")]
        [Display(Name = "FilmeTipo")]
        public string? tipo { get; set; }

        [Column("FilmeDuracao")]
        [Display(Name = "FilmeDuracao")]
        public string? duracao { get; set; }
    }
}
