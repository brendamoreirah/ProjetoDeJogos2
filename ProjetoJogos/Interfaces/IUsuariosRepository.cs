using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IUsuariosRepository
    {

        void Cadastrar(Usuarios Novousuario);

        void Deletar(Guid idDoUsuario);

        List<Usuarios> Listar();

        void Atualizar( Guid idDoUsuario, Usuarios usuarioAtualizado);

        Usuarios BuscarPorId(Guid id);
    }
}
