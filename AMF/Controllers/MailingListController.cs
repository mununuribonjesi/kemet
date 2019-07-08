﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMF.Data.Interfaces;
using AMF.Entities.DTOs;
using AMF.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AMF.Controllers
{
    [Route("api/[controller]")]
    public class MailingListController : Controller
    {
        private readonly MailingListService _mailingListService;


        public MailingListController(MailingListService mailingListService)
        {
            _mailingListService = mailingListService;
        }

        [HttpPost("addMailList")]
        public void AddMailList([FromBody] MailingList Mail)
        {
            _mailingListService.Add(Mail);
        }


        [Route("mailList")]
        [HttpGet]
        public IActionResult GetMailingList()
        {
            try
            {
                return Ok(_mailingListService);
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception);
            }

        }
    }
}
