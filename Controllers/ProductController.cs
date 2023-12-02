using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ProjectManagementApi.Models;

namespace ProjectManagementApi.Controllers;

[Route("products")]
public class ProductController : Controller
{
    private readonly ProductContext _db;
    
    public ProductController(ProductContext db)
    {
        _db = db;
    }
    
    
    [HttpGet]
    [Route("")]
    public IActionResult Get()
    {
        var product = _db.Products.First();
        
        return Json(product.ToString());
    }

    
    [HttpPost]
    [Route("")]
    public async Task<ActionResult<Product>> Store(Product product)
    {
        _db.Products.Add(product);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = product.Id}, product);

    }
}