using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string key,string category)
    {
        var products=Repository.Products;

        if(!string.IsNullOrEmpty(key)){
            ViewBag.key=key;
            products=products.Where(p=>p.Name.ToLower().Contains(key)).ToList();
        }

        if(!string.IsNullOrEmpty(category) && category!="0"){
            products=products.Where(p=>p.CategoryId==int.Parse(category)).ToList();
        }

        // ViewBag.Categories=new SelectList(Repository.Categories,"CategoryId","Name",category);

        var model=new ProductViewModel{
            Products=products,
            Categories=Repository.Categories,
            SelectedValue=category
        };

        return View(model);
    }
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories=new SelectList(Repository.Categories,"CategoryId","Name");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product model)
    {
        return View();
    }
}
