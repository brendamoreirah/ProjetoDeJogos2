using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
//Namespace -> Caminho em que a classe jogo está
namespace ProjetoDeJogos.Domains
{
    [Table("Jogos")]
    // O Index faz com que o nomeDoJogo não se repita
    [Index(nameof(nomeDoJogo), IsUnique = true)]
    //Public class -> Cria uma classe pública
    public class Jogo
    { //Preencher os atributos 
        [Key]
        public Guid JogoID { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string? nomeDoJogo { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        //O required faz com que seja obrigatório preencher o campo nomeDoJogo
        public string? plataforma { get; set; }

    }
}