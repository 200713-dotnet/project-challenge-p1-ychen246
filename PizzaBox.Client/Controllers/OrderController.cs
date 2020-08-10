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
      return View("Order", new PizzaViewModel());
    }

    public IActionResult Post(PizzaViewModel pizzaViewModel) 
    {
      if (ModelState.IsValid) 
      {
        var p = new PizzaFactory(); 

        return Redirect("/user/index"); 
      }

      return View("Order", pizzaViewModel);
    }
  }
}