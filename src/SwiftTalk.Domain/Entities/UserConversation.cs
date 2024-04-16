using SwiftTalk.Domain.Commons;

namespace SwiftTalk.Domain.Entities;

public class UserConversation : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public long ConversationId { get; set;}
    public Conversation Conversation { get; set;}
}