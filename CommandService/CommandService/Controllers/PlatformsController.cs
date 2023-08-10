using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
     [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformController: ControllerBase
    {
         private readonly IMapper _mapper;
           public PlatformController()
        {
     
        }
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controler");
        }


    }
}