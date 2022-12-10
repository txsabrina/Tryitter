using Microsoft.AspNetCore.Mvc;
using Tryitter.Context;
using Tryitter.Models;
using Microsoft.EntityFrameworkCore;

namespace Tryitter.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContasController : ControllerBase
  {
    private readonly AppDbContext _context;

    public ContasController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet("postagens")]
    public ActionResult<IEnumerable<Conta>> GetContasPostagens()
    {
      var result = _context.Contas.Include(p => p.Postagens).ToList();
      return result;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Conta>> Get()
    {
      var contas = _context.Contas.ToList();
      if (contas is null) return NotFound("Contas não encontradas.");
      return contas;
    }

    [HttpGet("{id:int}", Name="ObterConta")]
    public ActionResult<Conta> Get(int id)
    {
      var conta = _context.Contas.FirstOrDefault(c => c.ContaId == id);
      if (conta is null) return NotFound("Conta não encontrada.");
      return conta;
    }

    [HttpPost]
    public ActionResult Post(Conta conta)
    {
      if (conta is null) return BadRequest();

      _context.Contas.Add(conta);
      _context.SaveChanges();

      return new CreatedAtRouteResult("ObterConta", new { id = conta.ContaId }, conta);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Conta conta)
    {
      if (id != conta.ContaId) return BadRequest();

      _context.Entry(conta).State = EntityState.Modified;
      _context.SaveChanges();

      return Ok(conta);
    }

    [HttpDelete("{id:int}")]
    public ActionResult<Conta> Delete(int id)
    {
      var conta = _context.Contas.FirstOrDefault(c => c.ContaId == id);
      if (conta is null) return NotFound("Conta não localizada.");
      
      _context.Contas.Remove(conta);
      _context.SaveChanges();

      return Ok(conta);
    }
  }
}