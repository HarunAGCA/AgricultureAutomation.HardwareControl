using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgricultureAutomation.HardwareControl.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureAutomation.HardwareControl.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LedController : ControllerBase
    {
        private ILedService _LedService;

        public LedController(ILedService ledService)
        {
            _LedService = ledService;
        }

        [Route("Open")]
        public IActionResult Open()
        {
            _LedService.Open();
            return Ok("Opened");
        }

        [Route("Close")]
        public IActionResult Close()
        {
            _LedService.Close();
            return Ok("Closed");
        }
    }
}