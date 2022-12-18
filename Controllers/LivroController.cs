using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [ApiController]
    [Route("api/")]
    public class LivroController : ControllerBase
    {
        [HttpGet("livros-nao-tipado")]
        public IActionResult ObterTodosNaoTipado(){
            var livros = Livro.ObterLivros();
            return Ok(livros);
        }
        
        [HttpGet("livros-tipado")]
        public ActionResult<IEnumerable<Livro>> ObterTodosTipado(){
            var livros = Livro.ObterLivros();
            return Ok(livros);
        }

        /// <summary>
        /// Obtém todos os livros.
        /// </summary>
        /// <returns>Retorna os livros encontrados</returns>
        /// <response code="200">Retorna os livros encontrados</response>
        [ProducesResponseTypeAttribute(StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest)]
        [HttpGet("livros")]
        public ActionResult<IEnumerable<Livro>> ObterTodos()
        {
            var livros = Livro.ObterLivros();
            return Ok(livros);
        }
    }
}