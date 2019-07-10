
using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;
using AMF.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AMF.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        private readonly IEMailService _emailService;

        public EmailController(IEMailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("addEmail")]
        public void AddMailList([FromBody] SubscribedEmails Mail)
        {
            _emailService.Add(Mail);
        }
    }
}