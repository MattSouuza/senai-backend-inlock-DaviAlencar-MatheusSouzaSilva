using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }

        public JogoController()
        {
            _jogoRepository = new JogoRepository();
        }

        /// <summary>
        /// Lista todos os jogos
        /// </summary>
        /// <returns>Retorna uma lista de jogos</returns>
        [HttpGet]
        public IEnumerable<JogoDomain> Get()
        {
            return _jogoRepository.Listar();
        }

        /// <summary>
        /// Cadastra um novo jogo
        /// </summary>
        /// <param name="jogoNovo">Objeto jogoNovo que será cadastrado</param>
        /// <returns>Retorna um BadRequest - 400, ou um Created - 201 se cadastrado com sucesso</returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Authorize(Roles = "1")]
        public IActionResult Post(JogoDomain jogoNovo)
        {
            _jogoRepository.Cadastrar(jogoNovo);

            if (jogoNovo.NomeJogo == null)
            {
                return BadRequest();
            }

            return StatusCode(201);
        }
    }
}