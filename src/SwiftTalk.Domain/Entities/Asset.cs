using SwiftTalk.Domain.Commons;

namespace SwiftTalk.Domain.Entities;

public class Asset : Auditable
{
    public string Name { get; set; }
    public string Path { get; set; }
}
