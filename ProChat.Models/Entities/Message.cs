using ProChat.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProChat.Models.Entities
{
    public class Message : IEntity
    {
        [Key]
        public Guid Id { get; init; }
        public ICollection<User>? SeenUsers { get; set; }
        public Message? RepliedMessage { get; init; }
        public DateTimeOffset SendingTime { get; init; }
        public bool IsForwarded { get; set; } = false;
        public bool IsEdited { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public string Text { get; set; } = string.Empty;
        public MessageStatus Status { get; set; }
        public Chat Chat { get; init; }
        public User User { get; init; }
    }
}
