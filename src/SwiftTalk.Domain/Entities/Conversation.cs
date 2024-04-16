using SwiftTalk.Domain.Commons;

namespace SwiftTalk.Domain.Entities;

public class Conversation : Auditable
{
    public long FirstUserId { get; set; }
    public User FirstUser { get; set; }
    public long SecondUserId { get; set; }
    public User SecondUser { get; set; }
}
