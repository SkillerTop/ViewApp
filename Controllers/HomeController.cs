using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Пиріжок з вишнею", Price = 10.99M, CreatedDate = DateTime.Now.AddDays(-5) },
            new Product { ID = 2, Name = "Пиріжок з мясом", Price = 19.99M, CreatedDate = DateTime.Now.AddDays(-3) },
            new Product { ID = 3, Name = "Пиріжок з сливою", Price = 5.99M, CreatedDate = DateTime.Now.AddDays(-1) }
        };

        return View(products);
    }
}
