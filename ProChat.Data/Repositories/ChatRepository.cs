using ProChat.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProChat.Data.Repositories
{
    public class ChatRepository : IChatRepository<Chat>
    {
        private readonly DataContext _dataContext;
        public ChatRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        

        
    }
}
