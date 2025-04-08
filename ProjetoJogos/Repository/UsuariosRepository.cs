
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
        /// <summary>
        /// _Context serve para puxar as informacoes do Context do BD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="usuario"></param>
        public void Atualizar(Guid idDoUsuario, Usuarios usuarioAtualizando)
        {
            try
            {
                Usuarios usuarios = _context.Usuarios.Find(idDoUsuario)!;

                if (usuarios != null)
                {
                    usuarios.Nome = usuarios.Nome;
                }

                _context.Usuarios.Update(usuarios!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            try
            {
                novoUsuario.UsuarioID = Guid.NewGuid();

                _context.Usuarios.Add(novoUsuario);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid idDoUsuario)
        {
            try
            {
                Usuarios usuarios = _context.Usuarios.Find(idDoUsuario)!;
                if (usuarios != null)
                {
                    _context.Usuarios.Remove(usuarios);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuarios> Listar()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                return _context.Usuarios.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}