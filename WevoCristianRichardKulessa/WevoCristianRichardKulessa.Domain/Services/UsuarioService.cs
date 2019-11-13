using WevoCristianRichardKulessa.Domain.Entities;
using WevoCristianRichardKulessa.Domain.Repositories.Interfaces;
using WevoCristianRichardKulessa.Domain.Services.Interfaces;

namespace WevoCristianRichardKulessa.Domain.Services
{
    public class UsuarioService: ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository repository;

        public UsuarioService(IUsuarioRepository repository): base(repository)
        {
            this.repository = repository;
        }
    }
}
