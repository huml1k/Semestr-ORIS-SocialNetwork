using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Application.Features.Messager.Commands.SendMessage
{
    public record SendMessageCommand(string SenderId, int ChatId, string Text) : IRequest;
}
