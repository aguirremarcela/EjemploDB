using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using EntityFrameworkDB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EntityFrameworkDB.Data.Repository
{
    public interface IGenericRepository<T, TId>
    {
        T Insert(T t);
        T? GetById(TId id);//puede pasar que no siempre sea entero el id entonces pasamos uno generico
        IQueryable<T> GetAll();
        void Update(T t);
        bool Delete(TId id);
    }

    public abstract class GenericRepository<T, TId> : IGenericRepository<T, TId>
        where T : Model<TId>
        where TId : IEquatable<TId>
    {
        private readonly DataDBContext _context;
        protected DbSet<T> Entities => _context.Set<T>();


        protected GenericRepository(DataDBContext context)
        {
            _context = context;
        }
        public bool Delete(TId id)
        {
            T? t= this.GetById(id);
            if (t == null)
            {
                return false;
            }
            else
            {
                _context.Set<T>().Remove(t);
                return true;
            }
        }

        public IQueryable<T> GetAll() => _context.Set<T>();

        public T? GetById(TId id) => _context.Set<T>().First(a=>a.Id.Equals(id));

        public T Insert(T t)
        {
            EntityEntry<T> insertedValue = _context.Set<T>().Add(t);
            _context.SaveChanges();
            return insertedValue.Entity;
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
        }
    }
}
