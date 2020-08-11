using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  public class OrderController : Controller
  {
    private readonly PizzaBoxDbContext _db;

    public OrderController(PizzaBoxDbContext dbContext) 
    {
      _db = dbContext;
    }
    
    public IActionResult Start()
    {
      ViewBag.Crust = _db.Crusts.ToList();
      ViewBag.Size = _db.Sizes.ToList();
      ViewBag.Topping = _db.Toppings.ToList();
      return View("Order", new PizzaViewModel(ViewBag.Crust, ViewBag.Size, ViewBag.Topping));
    }
  }
}
