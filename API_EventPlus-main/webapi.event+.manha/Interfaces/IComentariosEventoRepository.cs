using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IComentariosEventoRepository
    {
        void Cadastrar(ComentariosEvento comentarioEvento);

        List<ComentariosEvento> Listar();

        void Deletar(Guid id);

        ComentariosEvento BuscarPorId(Guid id);


    }
}
