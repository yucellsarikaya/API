using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramawork
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() //TEntity için koşul verildi
        where TContext : DbContext, new() //TEntity için koşul verildi
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity); //gönderilen entity yi context.Entriy ye çeviyoruz
                addedEntity.State = EntityState.Added; //yapılmak istenilen işlemi yazıyorouz
                context.SaveChanges(); //sonucu db ye ekliyoruz
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //verilen filtreye göre verileri çeker
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null //filtrenin içine bakılır eğer
                    ? context.Set<TEntity>().ToList() //yoksa listeyi getirilir
                    : context.Set<TEntity>().Where(filter).ToList(); //filtreye göre varsa ona göre liste getirir
            }
        }
    }
}
