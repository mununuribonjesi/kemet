using System;
using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;
using AMF.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AMF.Controllers
{
    [Route("api/[controller]")]
    public class MailingListController : Controller
    {
        private readonly IMailingListService _mailingListService;

        public MailingListController(IMailingListService mailingListService)
        {
            _mailingListService = mailingListService;
        }

        [HttpPost("addSubscriber")]
        public void AddMailList([FromBody] Subscribers Mail)
        {
            _mailingListService.Add(Mail);
        }

        }
}
