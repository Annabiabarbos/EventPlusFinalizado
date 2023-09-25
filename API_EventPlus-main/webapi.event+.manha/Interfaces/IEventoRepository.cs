using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IEventoRepository
    {

        void Cadastrar(Evento evento);

        List<Evento> Listar();

        void Atualizar(Guid id, Evento evento);

        void Deletar (Guid id);

        Evento BuscarPorId(Guid id);
        
    }
}
