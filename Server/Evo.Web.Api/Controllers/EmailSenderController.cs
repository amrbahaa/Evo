using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Evo.Core.EmailSenderContracts;

namespace Evo.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/EmailSender")]
    public class EmailSenderController : Controller
    {
        private IEmailSender _emailSender;

        public EmailSenderController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        // GET api/EmailSender/psobhy@integrant.com
        [HttpGet("{email}")]
        public void Get(string email)
        {
            this._emailSender.SendEmail(email);
        }
    }
}