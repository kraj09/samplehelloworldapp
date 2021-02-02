using Domain.Abstract;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{   
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IMessage _message;
        public ValuesController(IMessage message)
        {
            _message = message;
        }

        [HttpGet]
        [Route("api/getmessage")]
        public async Task<string> GetMessage()
        {
            var data = await _message.GetMessage();
            return data.Message;
        }
    }
}
