using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/request/[controller]")]
    public class TesteController : ControllerBase
    {

        [HttpGet("TesteGet")]
        public IActionResult TesteGet()
        {
            return Ok(new { resposta = "Solicitação GET enviada com sucesso!" });
        }

        [HttpPost("TestePost")]
        public IActionResult TestePost()
        {
            return Ok(new { resposta = "Solicitação POST enviada com sucesso!" });
        }

    }
}