using WevoCristianRichardKulessa.Application.Services.Interfaces;
using WevoCristianRichardKulessa.Domain.Entities;
using WevoCristianRichardKulessa.Domain.Services.Interfaces;

namespace WevoCristianRichardKulessa.Application.Services
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService service;

        public UsuarioAppService(IUsuarioService service): base(service)
        {
            this.service = service;
        }
    }
}
