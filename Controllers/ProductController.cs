using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;

namespace ProjectManagementApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : Controller
{
    private readonly ProductContext _db;
    
    public ProductController(ProductContext db)
    {
        _db = db;
    }
    
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> All()
    {
        return await _db.Products.Select((x) => ItemToDto(x)).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> Get(int id)
    {
        var product = await _db.Products.FindAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        return ItemToDto(product);
    }
    
    [HttpPost]
    public async Task<ActionResult<Product>> Store(Product product)
    {
        _db.Products.Add(product);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = product.Id}, product);
    }

    private static ProductDto ItemToDto(Product product) => new ProductDto
    {
        Id = product.Id,
        Name = product.Name,
        Description = product.Description,
    };
}