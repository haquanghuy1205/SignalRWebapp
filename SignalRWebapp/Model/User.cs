using Microsoft.AspNetCore.Identity;

namespace Models
{
    public class User: IdentityUser
    {
        public ICollection<ChatUser> Chats { get; set; }
    }
}
