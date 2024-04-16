using SwiftTalk.Domain.Commons;

namespace SwiftTalk.Domain.Entities;

public class Conversation : Auditable
{
    public IEnumerable<UserConversation> UserConversations { get; set; }
    public IEnumerable<Message> Messages { get; set; }
}
