using Microsoft.AspNetCore.Mvc;
using SOSPets.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSPets.Application.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("user")]
        public IActionResult Testing()
            => Ok(new ResultDefault<object>(new { teste = "teste" }));
    }
}
