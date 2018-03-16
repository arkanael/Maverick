using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maverick.Data.Contratos;
using Maverick.Data.Implementacao.Contexto;
using System.Data.Entity;

namespace Maverick.Data.Implementacao.Repositorios
{
    public abstract class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        //Atributo para a classe de contexto
        protected readonly DataContext context;

        public BaseRepositorio()
        {
            context = new DataContext();
        }

        public void Insert(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
        
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
