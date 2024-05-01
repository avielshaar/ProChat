using ProChat.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProChat.Models.Entities
{
    public class Chat : IEntity
    {
        [Key]
        public Guid Id { get; init; }
        public ChatType Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BackgroundPicturePath { get; set; } = string.Empty;
        public string ProfilePicturePath { get; set; } = string.Empty;
        public User Owner { get; init; }
        public ICollection<User> Admins { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
