using ApiFuncional.Data;
using ApiFuncional.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncional.Controllers;

[ApiController]
[Route("api/produtos")]

public class ProdutosController : ControllerBase
{
    private readonly ApiDbContext _context;

    public ProdutosController(ApiDbContext apiDbContext)
    {
            _context = apiDbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
    {
        return Ok(await _context.Produtos.ToListAsync());
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<Produto>> GetProduto(Guid id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        return Ok(produto);
    }

    [HttpPost]
    public async Task<ActionResult<Produto>> PostProduto(Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
    }

    [HttpPut("{id:Guid}")]
    public async Task<ActionResult<Produto>> PutProduto(Produto produto)
    {
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<Produto>> DeleteProduto(Guid id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
