using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories
{
  public class PizzaFactory : IFactory
  {
    public AModel Create()
    {
      var p = new PizzaModel();

      p.Crust = new CrustModel();
      p.Size = new SizeModel();
      p.Toppings = new List<ToppingModel>{ new ToppingModel() };

      return p;
    }

    public AModel Update(PizzaModel pizza, CrustModel crust, SizeModel size, List<ToppingModel> toppings)
    {

      pizza.Crust = crust;
      pizza.Size = size;
      pizza.Toppings = toppings;

      return pizza;
    }
  }
}
