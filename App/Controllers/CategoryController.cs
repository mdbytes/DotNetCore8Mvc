using App.Data;
using App.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;

    }

    // GET
    public IActionResult Index()
    {
        List<Category> objCategoryList = _db.Categories.ToList();

        return View(objCategoryList);
    }

    public IActionResult Create(Category category)
    {
        return View();
    }
}