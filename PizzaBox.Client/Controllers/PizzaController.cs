using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Models;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  public class PizzaController : Controller
  {
    private readonly PizzaBoxDbContext _db;

    public PizzaController(PizzaBoxDbContext dbContext)
    {
      _db = dbContext;
    }

    public IActionResult Add()
    {
      ViewBag.Crust = _db.Crusts.ToList();
      ViewBag.Size = _db.Sizes.ToList();
      ViewBag.Topping = _db.Toppings.ToList();
      return View("AddPizza", new PizzaViewModel(ViewBag.Crust, ViewBag.Size, ViewBag.Toppings));
    }
  }
}
