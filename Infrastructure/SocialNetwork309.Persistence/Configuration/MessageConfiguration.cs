using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork309.Domain.Entities.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Persistence.Configuration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Text)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(m => m.SentAt)
                   .IsRequired();

            builder.HasIndex(m => m.ChatId);

            // Внешний ключ: Message -> Chat
            builder.HasOne(m => m.Chat)
                   .WithMany() // или .WithMany(c => c.Messages) если ты вернёшь коллекцию
                   .HasForeignKey(m => m.ChatId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Внешний ключ: Message -> Sender (IdentityUser)
            builder.HasOne<IdentityUser>(m => m.Sender)
                   .WithMany()
                   .HasForeignKey(m => m.SenderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Messages");
        }
    }
}
