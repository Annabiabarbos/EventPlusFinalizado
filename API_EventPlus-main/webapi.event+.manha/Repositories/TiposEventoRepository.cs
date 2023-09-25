using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {
        private readonly EventContext _eventContext;
        private object ctx;

        public TiposEventoRepository()
        {
            _eventContext = new EventContext();
        }
        public void Atualizar(Guid id, TiposEvento tipoEvento)
        {
            TiposEvento tipoEventoBuscado = _eventContext.TiposEvento.Find(id);
           
            if(tipoEventoBuscado != null)
            {
                tipoEventoBuscado.Titulo = tipoEvento.Titulo;
            }
            _eventContext.TiposEvento.Update(tipoEventoBuscado); ;

            _eventContext.SaveChanges();

        }

        public TiposEvento BuscarPorId(Guid id)
        {
            return _eventContext.TiposEvento.Find(id); 
           
        }

        public void Cadastrar(TiposEvento tipoEvento)
        {
            _eventContext.TiposEvento.Add(tipoEvento);

            _eventContext.SaveChanges();
            
        }

        public void Deletar(Guid id)
        {
            TiposEvento tipoEventobuscado = _eventContext.TiposEvento.Find(id);

            _eventContext.TiposEvento.Remove(tipoEventobuscado);

            _eventContext.SaveChanges();
        }

        public List<TiposEvento> Listar(Guid id, TiposEvento tiposEvento)
        {
            return _eventContext.TiposEvento.ToList();
        }
    }
}

