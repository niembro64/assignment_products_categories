using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment_products_categories.Models;
using Microsoft.EntityFrameworkCore;

namespace assignment_products_categories.Controllers
{
  public class HomeController : Controller
  {
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
      _logger = logger;
      _context = context;
    }


    public IActionResult Index()
    {
      ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
      ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
      return View("Products");
    }
    public IActionResult Categories()
    {
      ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
      ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();

      return View();
    }
    public IActionResult Products()
    {
      ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
      ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
      return View();
    }

    //////////

    [HttpPost("product/add")]
    public IActionResult AddProduct(Product newProduct)
    {
      if (ModelState.IsValid)
      {
        _context.Products.Add(newProduct);
        _context.SaveChanges();

        ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
        ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
        return RedirectToAction("Products");
      }
      else
      {
        ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
        ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
        return View("Products");
      }
    }
    [HttpPost("category/add")]
    public IActionResult AddCategory(Category newCategory)
    {
      if (ModelState.IsValid)
      {
        _context.Categories.Add(newCategory);
        _context.SaveChanges();

        ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
        ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
        return RedirectToAction("Categories");
      }
      else
      {
        ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
        ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
        return View("Categories");
      }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
