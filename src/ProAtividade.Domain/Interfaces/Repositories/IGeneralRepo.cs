using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAtividade.Domain.Interfaces.Repositories
{
    public interface IGeneralRepo
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteMultiple<T> (T[] entity) where T: class;

        Task<bool> SaveAlterationsAsync();
    }
}