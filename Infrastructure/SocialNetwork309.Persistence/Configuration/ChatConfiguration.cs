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
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Отношение Chat -> Sender (IdentityUser)
            builder.HasOne<IdentityUser>(c => c.Sender)
                   .WithMany() // Можно указать .WithMany("CreatedChats") если добавить навигацию в IdentityUser
                   .HasForeignKey(c => c.SenderId)
                   .OnDelete(DeleteBehavior.Restrict); // важно, иначе при удалении юзера удалятся чаты

            // Связь Chat -> Messages (если раскомментируешь)
            builder.HasMany<Message>()
                   .WithOne(m => m.Chat)
                   .HasForeignKey(m => m.ChatId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Chats");
        }
    }
}
