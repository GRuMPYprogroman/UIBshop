using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController(PizzaStoreContext _db) : Controller
{
    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return await _db.Specials
                                    .OrderByDescending(s => s.BasePrice)
                                    .ToListAsync();
    }
}