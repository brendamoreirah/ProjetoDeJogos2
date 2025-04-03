using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;
using ProjetoDeJogos.Migrations;

namespace ProjetoDeJogos.Repository
{
    public class JogosRepository : IJogosRepository
    {

        private readonly ProjetoJogosContext _context;

        public JogosRepository(ProjetoJogosContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid idDoJogo, Jogo jogoAtualizado)
        {
            try
            {
                Jogo jogos1 = _context.Jogos.Find(idDoJogo)!;

                if (jogo != null)
                {
                    jogo.NomeDoJogo = jogo.NomeDoJogo;
                }

                _context.Jogos.Update(jogo!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Jogo jogoNovo)
        {
            try
            {
                jogoNovo.JogoID = Guid.NewGuid();
                _context.Jogos.Add(jogoNovo);  
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid idDoJogo)
        {
            throw new NotImplementedException();
        }

        public List<DbJogos> List()
        {
            throw new NotImplementedException();
        }
    }
}
