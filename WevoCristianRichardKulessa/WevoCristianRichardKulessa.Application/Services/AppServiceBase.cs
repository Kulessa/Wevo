using System;
using System.Linq;
using WevoCristianRichardKulessa.Application.Services.Interfaces;
using WevoCristianRichardKulessa.Domain.Services.Interfaces;

namespace WevoCristianRichardKulessa.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            this.service = service;
        }
        public void Delete(int id)
        {
            service.Delete(id);
        }

        public void Dispose()
        {
            service.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Exists(int id)
        {
            return service.Exists(id);
        }

        public void Insert(TEntity entity)
        {
            service.Insert(entity);
        }

        public IQueryable<TEntity> Select()
        {
            return service.Select();
        }

        public TEntity Select(int id)
        {
            return service.Select(id);
        }

        public void Update(TEntity entity)
        {
            service.Update(entity);
        }
    }
}
