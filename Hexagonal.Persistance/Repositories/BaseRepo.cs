using Hexagonal.Persistance.Model;
using System.Collections.Generic;
using System.Linq;

namespace Hexagonal.Persistance.Repositories
{
    public interface IBaseRepo<T> where T: BaseEnity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Delete(int id);
    }
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEnity
    {
        public BaseRepo()
        {
          
        }
        public void Delete(int id)
        {
            var list = DataContext.Instance.GetListInMemory<T>();
            list.Remove(list.Find(x => x.Id ==id) as T);
        }

        public IEnumerable<T> GetAll()
        {
            return DataContext.Instance.GetListInMemory<T>();
        }

        public T GetById(int id)
        {
            var list = DataContext.Instance.GetListInMemory<T>();
            return list.Find(x => x.Id == id);
        }

        public void Insert(T obj)
        {
            var list = DataContext.Instance.GetListInMemory<T>();
            obj.Id = list.Count()+1;
            list.Add(obj);
        }
    }

   
}
