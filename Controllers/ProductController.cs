using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ProjectManagementApi.Controllers;

[Route("products")]
public class ProductController : Controller
{
    private readonly DbContext _db;
    
    public ProductController(DbContext db)
    {
        _db = db;
    }
    
    
    // GET
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        var product = _db.Products.First();
        
        return Json(product.ToString());
    }
}