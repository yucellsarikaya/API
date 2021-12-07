using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //t için şart koyduk class olacak, IEntity türünden olacak, gönderilen nesne newlene bilmesi lazım
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter); //filtrlenmiş bir şekilde liste getirir
        IList<T> GetList(Expression<Func<T, bool>> filter = null); //tüm listeyi getirir
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
