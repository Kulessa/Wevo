using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WevoCristianRichardKulessa.Application.WebAPI.Models;

namespace WevoCristianRichardKulessa.Application.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public UsuariosController(){}
        [HttpGet]
        public Task<ActionResult<IEnumerable<UsuarioModel>>> GetUsuarios()
        {
            throw new NotImplementedException();
        }
        [HttpGet("{id}")]
        public Task<ActionResult<UsuarioModel>> GetUsuario(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPut("{id}")]
        public Task<ActionResult<UsuarioModel>> PutUsuario(int id, UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
        [HttpPost()]
        public Task<ActionResult<UsuarioModel>> PostUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("{id}")]
        public Task<ActionResult<UsuarioModel>> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}