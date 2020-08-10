using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    // out to the client
    public List<PizzaModel> Pizzas { get; set; }

    // in from the client

    
    public OrderViewModel()
    {
      
    }

    public OrderViewModel(PizzaModel pizza)
    {
      Pizzas.Add(pizza);
    }
  }
}

