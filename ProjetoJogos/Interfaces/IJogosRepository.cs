using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IJogosRepository
    {
        void Cadastrar(Jogo jogoNovo);

        void Deletar(Guid idDoJogo);

        List<Jogo> List();

        void Atualizar(Guid idDoJogo, Jogo jogoAtualizado);

        Jogo BuscarPorId(Guid id);
    }
}
