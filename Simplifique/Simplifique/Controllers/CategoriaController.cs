using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simplifique.Domain;
using Simplifique.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Simplifique.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaRepository _categoria;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoria = categoriaRepository;
        }

        [HttpGet("/api/categorias")]
        public async Task<IActionResult> ConsultarCategorias()
        {
            var categorias = await _categoria.ConsultarCategorias();
            return Ok(categorias);
        }

        [HttpGet("/api/categorias/{id}")]
        public async Task<IActionResult> ConsultarCategoriaPorId(Guid id)
        {
            var categoria = await _categoria.ConsultarCategoriaPorId(id);
            return Ok(categoria);
        }

        [HttpPost("/api/categoria")]
        public async Task<IActionResult> CadastrarCategoria([FromBody] Categoria categoriaitem)
        {
            var cadastrarCategoria = await _categoria.CadastrarCategoria(categoriaitem);
            return Ok(cadastrarCategoria);
        }

        [HttpPut("/api/categoria/{id}")]
        public async Task<IActionResult> AtualizarCategoria(Guid id, [FromBody] Categoria categoriaInserida)
        {
            var atualizarCategoria = await _categoria.AtualizarCategoria(id, categoriaInserida);
            return Ok(atualizarCategoria);
        }

    }
}
