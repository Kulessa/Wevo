using WevoCristianRichardKulessa.Domain.Entities;
using WevoCristianRichardKulessa.Domain.Repositories.Interfaces;
using WevoCristianRichardKulessa.Infrastructure.Data.Context;

namespace WevoCristianRichardKulessa.Infrastructure.Data.Repositories
{
    public class UsuarioRepository: RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(WevoCristianRichardKulessaContext context) : base(context) { }
    }
}
