﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Dto;
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
    public async Task<ActionResult<IEnumerable<ProductDto>>> All([FromQuery(Name = "offset")] int offset = 0, [FromQuery(Name = "pages")] int pages = 10, [FromQuery(Name = "desc")] bool desc = false)
    {
        var query = _db.Products.AsQueryable();

        if (desc)
        {
            query = query.OrderByDescending((x) => x.Id);
        }

        return await query
            .Skip(offset)
            .Take(pages)
            .Select((x) => ItemToDto(x))
            .ToListAsync();
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
    
    [HttpPut]
    //TODO: use pretty product to remove id "requirement"
    public async Task<ActionResult<Product>> Store([FromBody]PrettyProduct productData)
    {
        var entry = _db.Products.Add(new Product() {Name = productData.Name ?? "",Description = productData.Description});
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = entry.Entity.Id}, entry.Entity);
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<ProductDto>> Update(int id, [FromBody]PrettyProduct updateData)
    {
        var product = await _db.Products.FindAsync(id);

        if (product == null)
        {
            return StatusCode(404);
        }


        if (updateData.Description != null)
        {
            product.Description = updateData.Description;
        }

        if (updateData.Name != null)
        {
            product.Name = updateData.Name;
        }
        
        await _db.SaveChangesAsync();

        return StatusCode(204);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Product>> Delete(int id)
    {
        var deleted = await _db.Products.Where(p => p.Id == id).ExecuteDeleteAsync();

        if (deleted != 1)
        {
            return NotFound();
        }
        
        return NoContent();
    }

    private static ProductDto ItemToDto(Product product) => new ProductDto
    {
        Id = product.Id,
        Name = product.Name,
        Description = product.Description,
    };
}