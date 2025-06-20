using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork309.Application.Features.Auth.Commands.Register;
using SocialNetwork309.Application.Features.Auth.Queries.Login;
using SocialNetwork309.Models.Auth;

namespace SocialNetwork309.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult Login([FromQuery]string? returnUrl)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var command = new RegisterCommand
            {
                Email = model.Email,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };

            var isSuccess = await _mediator.Send(command);

            if (isSuccess)
                return RedirectToAction("Index", "Home");

            // ModelState.AddModelError(string.Empty, result.Error);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var query = new LoginQuery(model.Email, model.Password);

            var isSuccess = await _mediator.Send(query);

            if (isSuccess)
                return RedirectToAction("Index", "Home");

            // ModelState.AddModelError(string.Empty, result.Error);

            return View(model);
        }
    }
}
