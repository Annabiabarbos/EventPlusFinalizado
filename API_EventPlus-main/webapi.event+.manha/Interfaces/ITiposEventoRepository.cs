using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface ITiposEventoRepository
    {
        void Cadastrar(TiposEvento tipoEvento);

        List<TiposEvento> Listar();

        void Atualizar(Guid id, TiposEvento tipoEvento);

        void Deletar(Guid id);

        TiposEvento BuscarPorId (Guid id);  
    }
}
