using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeJogos.Domains
{

    [Table("Usuarios")]
    [Index(nameof(Nickname), IsUnique = true)]
    public class Usuarios
    {
        //Preencher os atributos 
        [Key]
        public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "O nickname do jogo é obrigatório!")]
        public string? Nickname { get; set; }
        public Guid JogoFavorito { get; set; }

        [ForeignKey("JogoFavorito")]
        public Jogo? Jogo { get; set; }

    }
}