using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork309.Application.Features.Messager.Commands.SendMessage;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SocialNetwork309.Controllers
{
    public class ChatsController : Controller
    {
        private readonly IMediator _mediator;

        public ChatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: ChatsController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SendMessage(SendMessageCommand command)
        {
            
            await _mediator.Send(command);
            return View("Index");
        }

    }
}
