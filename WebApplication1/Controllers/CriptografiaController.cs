using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlowfishCSharp.Wrapper;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriptografiaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("criptografar")]
        public ActionResult<Mensagem> Criptografar([FromBody] Mensagem value)
        {
            lock(this)
            {
                var textoCript = BlowFishWrapper.Encrypt(value.mensagem);
                return Ok(new Mensagem
                {
                    mensagem = textoCript
                });
            }
        }

        [HttpPost("descriptografar")]
        public ActionResult<Mensagem> Descriptografar([FromBody] Mensagem value)
        {
            lock (this)
            {
                var textoCript = BlowFishWrapper.Decrypt(value.mensagem);
                return Ok(new Mensagem
                {
                    mensagem = textoCript
                });
            }
        }
    }
}