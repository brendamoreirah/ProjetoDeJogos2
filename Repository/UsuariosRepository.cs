using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ProjetoJogosContext _context;

        public UsuariosRepository(ProjetoJogosContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid idDoUsuario, Usuarios usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuarios Novousuario)
        {

            try
            {
               Novousuario.UsuarioID = Guid.NewGuid();
                _context.Usuarios.Add(Novousuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid idDoUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
