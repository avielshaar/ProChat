using ProChat.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProChat.Data.Repositories
{
    public interface IChatRepository<T> where T : IEntity
    {
        IEnumerable<T> GetByUserId(Guid Id);
        T GetById(Guid Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid Id);
    }
}
