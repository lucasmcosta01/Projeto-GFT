using System;
using System.Collections.Generic;


namespace NetSeries
{
    public interface IRepository<T>
    { 
        List<T> Lista();
        T ReturnId(int id);
        void Insert(T entidade);
        void Delete(int id);
        void Update(int id, T entidade);
        int NextId();
    }
}
