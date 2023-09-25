using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class PresencasEventoRepository : IPresencasEventoRepository
    {
        private readonly EventContext _eventContext;
        private object ctx;

        public PresencasEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, PresencasEvento presencaEvento)
        {
            PresencasEvento presencasEventoBuscado = _eventContext.PresencasEvento.Find(id);

            if(presencasEventoBuscado!= null)
            {
                presencasEventoBuscado.Evento = presencaEvento.Evento;
            }
            _eventContext.PresencasEvento.Update(presencasEventoBuscado);

            _eventContext.SaveChanges();
        }

        public PresencasEvento BuscarPorId(Guid id)
        {
            return _eventContext.PresencasEvento.Find(id);
        }

        public void Cadastrar(PresencasEvento presencaEvento)
        {
            _eventContext.PresencasEvento.Add(presencaEvento);

            _eventContext.SaveChanges();
         
        }

        public void Deletar(Guid id)
        {
            PresencasEvento presencasEventoBuscado = _eventContext.PresencasEvento.Find(id);

            _eventContext.TiposEvento.Remove(presencasEventoBuscado);
            
            _eventContext.SaveChanges();
        }

        public List<PresencasEvento> Listar()
        {
            throw new NotImplementedException();
        }

        public List<PresencasEvento> ListarMinhas(Guid id)
        {
            return _eventContext.PresencasEvento.ToList();
        }
    }
}
