using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]    
        public IActionResult Apresentar (string nome)
        {
            var mensagem = $"Olá, {nome}, seja bem vindo!";
            return Ok(new{mensagem});
        }

        [HttpGet ("DizerIdade/{idade}")]
        public IActionResult DizerIdade (int idade)
        {
            var msg = $"{idade} é a sua idade";
            return Ok(new {msg});
        }

        [HttpGet ("InfoOfAPerson/{name}/{age}")]
        public IActionResult InfoOfAPerson (string name, int age)
        {
            var message = $"Hello, {name}. You are {age} years old";
            return Ok(new {message});
        }
    }
}