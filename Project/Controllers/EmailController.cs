using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Model;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IMailService _mailService;
        public EmailController(IMailService mailService)
        {
            _mailService = mailService;
        }
        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await _mailService.SendEmailAsync(request);//for this specific task (Send) we wait until the SendEmailAsync(request) is finished, then we can continue with the rest of the method/task
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}
