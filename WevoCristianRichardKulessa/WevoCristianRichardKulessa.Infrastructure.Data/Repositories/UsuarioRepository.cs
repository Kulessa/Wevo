using WevoCristianRichardKulessa.Domain.Entities;
using WevoCristianRichardKulessa.Domain.Repositories.Interfaces;
using WevoCristianRichardKulessa.Infrastructure.Data.Context;

namespace WevoCristianRichardKulessa.Infrastructure.Data.Repositories
{
    public class UsuarioRepository: RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(WevoCristianRichardKulessaContext context) : base(context) { }

        public override void Update(Usuario entity)
        {
            DetachLocal(x => x.Id == entity.Id);
            base.Update(entity);    
        }
    }
}
