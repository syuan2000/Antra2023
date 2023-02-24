using System;
namespace O4Generic
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Remove(T obj);
        void Save(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}

