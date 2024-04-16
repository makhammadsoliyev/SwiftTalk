using SwiftTalk.Domain.Commons;

namespace SwiftTalk.Domain.Entities;

public class Message : Auditable
{
    public long SenderId { get; set; }
    public User Sender { get; set; }
    public long ConversationId { get; set; }
    public Conversation Conversation { get; set; }
    public string Content { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
    public long? MediaId { get; set; }
    public Asset Media { get; set; }
    public long? ReplyToMessageId { get; set; }
    public Message ReplyToMessage { get; set; }
}