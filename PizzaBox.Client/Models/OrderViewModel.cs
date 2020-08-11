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

    public List<StoreModel> Stores { get; set;}

    // in from the client
    public string User {get; set;}

    public string Store{get; set;}
    
    public OrderViewModel()
    {
      Pizzas = new List<PizzaModel>();
    }

    public void AddPizza(PizzaModel pizza)
    {
      Pizzas.Add(pizza);
    }

    public void LoadStores(List<StoreModel> stores)
    {
      Stores = stores;
    }
  }
}

