using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IPresencasEventoRepository
    {
        void Cadastrar(PresencasEvento presencaEvento);

        void Deletar(Guid id);

        List<PresencasEvento> Listar();

        void Atualizar(Guid id, PresencasEvento presencaEvento);

        List<PresencasEvento> ListarMinhas(Guid id);

        PresencasEvento BuscarPorId(Guid id);

    }
}
