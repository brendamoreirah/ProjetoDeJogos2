using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Migrations;

namespace ProjetoDeJogos.Interfaces
{
    public interface IJogosRepository
    {
        void Cadastrar(Jogo jogoNovo);

        void Deletar(Guid idDoJogo);

        List<DbJogos> List();

        void Atualizar(Guid idDoJogo, Jogo jogoAtualizado);
        
    }
}
