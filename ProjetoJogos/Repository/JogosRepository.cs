using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

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

               if (jogoAtualizado != null)
               {
                   jogoAtualizado.nomeDoJogo = jogoAtualizado.nomeDoJogo;               
               }

                _context.Jogos.Update(jogoAtualizado!);

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
           try
            {
               Jogo jogos = _context.Jogos.Find(idDoJogo)!;

                if (jogos != null)
               {
                   _context.Jogos.Remove(jogos);
               }

               _context.SaveChanges();
           }
            catch (Exception)
          {
             throw;
           }
        }

        List<Jogo> IJogosRepository.List()
        {
            try
            {
                return _context.Jogos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        Jogo IJogosRepository.BuscarPorId(Guid id)
        {
            try
            {
                return _context.Jogos.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}