using SwiftTalk.Domain.Commons;
using SwiftTalk.Domain.Enums;

namespace SwiftTalk.Domain.Entities;

public class User : Auditable
{ 
    public string Name { get; set; }
    public string Phone { get; set; }
    public string PasswordHash { get; set; }
    public Role Role { get; set; }
    public long? AvatarId { get; set; }
    public Asset Avatar { get; set; }
}