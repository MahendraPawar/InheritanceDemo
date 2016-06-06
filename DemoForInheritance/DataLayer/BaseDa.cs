using Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public abstract class BaseDa<T> :IBaseDa<T> where T:Entity
    {
        public virtual T Get(int id)
        {
            Console.WriteLine("From Get of base");
            return null;
        }

        public virtual List<T> GetList()
        {
            Console.WriteLine("From Getlist of base");
            return null;
        }

        public abstract int Insert(T obj);
    }

    public interface IBaseDa<T> where T:Entity
    {
        T Get(int id);
        List<T> GetList();
        int Insert(T obj);
    }
}
