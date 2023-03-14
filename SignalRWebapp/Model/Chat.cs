﻿namespace Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ChatType Type { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<ChatUser> ChatUsers { get; set; } = new List<ChatUser>();
    }
}
