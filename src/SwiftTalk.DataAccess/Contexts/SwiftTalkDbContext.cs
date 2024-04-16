using Microsoft.EntityFrameworkCore;
using SwiftTalk.Domain.Entities;

namespace SwiftTalk.DataAccess.Contexts;

public class SwiftTalkDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Conversation> Conversations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasOne(u => u.Avatar)
            .WithMany()
            .HasForeignKey(u => u.AvatarId);

        modelBuilder.Entity<User>()
            .HasMany(u => u.UserConversations)
            .WithOne(uc => uc.User)
            .HasForeignKey(c => c.UserId);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Messages)
            .WithOne(m => m.Sender)
            .HasForeignKey(m => m.SenderId);

        modelBuilder.Entity<Message>()
            .HasOne(m => m.Conversation)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ConversationId);

        modelBuilder.Entity<Message>()
            .HasOne(m => m.Media)
            .WithMany()
            .HasForeignKey(m => m.MediaId);

        modelBuilder.Entity<Message>()
            .HasOne(m => m.ReplyToMessage)
            .WithMany()
            .HasForeignKey(m => m.ReplyToMessageId);

        modelBuilder.Entity<Conversation>()
            .HasMany(c => c.UserConversations)
            .WithOne(uc => uc.Conversation)
            .HasForeignKey(c => c.ConversationId);
    }
}
