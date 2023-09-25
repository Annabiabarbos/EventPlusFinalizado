using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositories
{
    ///
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _eventContext;
        private object ctx;

        public TiposUsuarioRepository()
        {
            _eventContext = new EventContext();
        }
        /// <inheritdoc/>

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {

            TiposUsuario TiposusuarioBuscado = _eventContext.TiposUsuario.Find(id);  

            if (TiposusuarioBuscado != null )
            {
                TiposusuarioBuscado.Titulo = tipoUsuario.Titulo;
            }

            _eventContext.TiposUsuario.Update(TiposusuarioBuscado);
            _eventContext.SaveChanges();
         
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            return _eventContext.TiposUsuario.Find(id);
            
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tiposUsuarioBuscado = _eventContext.TiposUsuario.Find(id);

            _eventContext.TiposUsuario.Remove(tiposUsuarioBuscado);

            _eventContext.SaveChanges();
            
        }

        public List<TiposUsuario> Listar(Guid id , TiposUsuario tiposUsuario)
        {
            return _eventContext.TiposUsuario.ToList();
        }
    }
}
