using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Controllers
{
    internal interface IEventosController
    {
        void Cadastrar(Evento evento);
    }
}