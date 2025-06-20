using MediatR;
using Microsoft.AspNetCore.SignalR;
using SocialNetwork309.Application.Common;
using SocialNetwork309.Domain.Entities.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork309.Application.Features.Messager.Commands.SendMessage
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IHubContext<ChatHub, IChatClient> _hub;

        public SendMessageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_hub = hub;
        }

        public async Task Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
           
            var message = new Message
            {
                ChatId = request.ChatId,
                SenderId = request.SenderId,
                Text = request.Text,
                SentAt = DateTime.UtcNow
            };

            await _unitOfWork.Repository<Message>().AddAsync(message);
            

            await _unitOfWork.Save(cancellationToken);

            //var messageDto = new MessageDto
            //{
            //    Sender = message.Sender,
            //    Text = message.Text,
            //    SentAt = message.SentAt
            //};

            //await _hub.Clients.Group(chat.Id.ToString()).ReceiveMessage(chat.Id, messageDto);

            
        }
    }
}
