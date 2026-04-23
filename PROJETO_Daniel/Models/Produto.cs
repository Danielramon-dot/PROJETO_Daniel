using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PROJETO_Daniel.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }

    
    [Required]
    public string Nome { get; set; }

    [Required]
    public string Descricao { get; set; }

    [Required]
    public double Preco { get; set; }


    [Required]
    public int Estoque { get; set; }
    
    [Required]
    public string Url { get; set; }
   
}
