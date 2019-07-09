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

        [HttpPost("addMailList")]
        public void AddMailList([FromBody] Subscribers Mail)
        {
            _mailingListService.Add(Mail);
        }


        [Route("mailList")]
        [HttpGet]
        public IActionResult GetMailingList()
        {
            try
            {
                return Ok(_mailingListService.GetMailingList());
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception);
            }

        }
    }
}
