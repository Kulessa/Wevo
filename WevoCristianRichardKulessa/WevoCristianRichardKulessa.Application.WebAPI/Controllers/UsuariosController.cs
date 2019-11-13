using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WevoCristianRichardKulessa.Application.Services.Interfaces;
using WevoCristianRichardKulessa.Application.WebAPI.Models;
using WevoCristianRichardKulessa.Domain.Entities;

namespace WevoCristianRichardKulessa.Application.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioAppService appService;

        public UsuariosController(IUsuarioAppService appService)
        {
            this.appService = appService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UsuarioModel>> GetUsuarios()
        {
            try
            {
                var response = appService.Select()
                    .Select(p => new UsuarioModel()
                    {
                        CPF = p.Cpf,
                        DataNascimento = p.DataNascimento,
                        EMail = p.Email,
                        Id = p.Id,
                        Nome = p.Nome,
                        Sexo = p.Sexo,
                        Telefone = p.Telefone
                    }).ToList();
                if (response == null || response.Count==0)
                {
                    return NotFound();
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<UsuarioModel> GetUsuario(int id)
        {
            try
            {
                var response = appService.Select(id);
                if (response == null)
                {
                    return NotFound();
                }
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut()]
        public IActionResult PutUsuario(UsuarioModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                if (!appService.Exists(model.Id))
                {
                    return NotFound();
                }
                appService.Update(new Usuario
                {
                    Id = model.Id,
                    Cpf = model.CPF,
                    DataNascimento = model.DataNascimento,
                    Email = model.EMail,
                    Nome = model.Nome,
                    Sexo = model.Sexo,
                    Telefone = model.Telefone
                });
                return Ok();
            }
            catch(DbUpdateConcurrencyException e)
            {
                if (!appService.Exists(model.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost()]
        public IActionResult PostUsuario(UsuarioModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                appService.Insert(
                    new Usuario
                    {
                        Id = model.Id,
                        Cpf = model.CPF,
                        DataNascimento = model.DataNascimento,
                        Email = model.EMail,
                        Nome = model.Nome,
                        Sexo = model.Sexo,
                        Telefone = model.Telefone
                    });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            try
            {
                if (appService.Exists(id))
                {
                    return NotFound();
                }
                appService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}