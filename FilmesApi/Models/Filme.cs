using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O tamanho do titulo não pode exceder 50 caracteres.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração é obrigatória.")]
    [Range(70, 600, ErrorMessage = "A duração tem que ser entre 70 e 600 minutos.")]
    public int Duracao { get; set; }
    public int Id { get; internal set; }
}
