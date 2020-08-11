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
  public class UserController : Controller
  {
    private readonly PizzaBoxDbContext _db;

    public UserController(PizzaBoxDbContext dbContext) 
    {
      _db = dbContext;
    }
    
    public IActionResult Start()
    {
      return View("Home");
    }

    public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) 
    {
      var crust = _db.Crusts.FirstOrDefault( c => c.Name == pizzaViewModel.Crust);
      var size =_db.Sizes.FirstOrDefault( s => s.Name == pizzaViewModel.Size);
      List<ToppingModel> toppings = new List<ToppingModel>();
      foreach (var topping in pizzaViewModel.SelectedToppings)
      {
        var top =_db.Toppings.FirstOrDefault( t => t.Name == topping);
        toppings.Add(top);
      }
      PizzaFactory pf = new PizzaFactory();
      var pizza = pf.Create() as PizzaModel;
      var newPizza = pf.Update(pizza, crust, size, toppings) as PizzaModel;

      OrderViewModel orderViewModel = new OrderViewModel();
      orderViewModel.AddPizza(newPizza);

      return View("ShowOrder", orderViewModel);
    }
  }
}
