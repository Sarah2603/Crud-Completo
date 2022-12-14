using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
     public class UsuarioController : ControllerBase
     {
        [HttpGet("Obter Data e Hora Atuais")]
       
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()

            };
            return Ok(obj);
        }
       
        [HttpGet("Apresentar /{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá, {nome}! Seja bem vindo!";
            return Ok(new {mensagem});
        }
             
       
       
        
     }
}
       

    
     