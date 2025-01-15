using Microsoft.AspNetCore.Mvc;
using RPSLS.Services;

namespace RPSLS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly RPSLSServices _rpslsServices;
        public RPSLSController(RPSLSServices rPSLSServices)
        {
            _rpslsServices = rPSLSServices;
        }

        [HttpGet]
        [Route("RPSLS")]

        public string RPSLS()
        {
            return _rpslsServices.RPSLS();
        }
    }
}