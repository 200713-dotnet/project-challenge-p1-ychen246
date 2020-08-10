using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    // out to the client
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }


    // in from the client
    [Required]
    public string Crust { get; set; }
    [Required]
    public string Size { get; set; }
    [Range(2,5)]
    public List<string> SelectedToppings { get; set; }

    public PizzaViewModel()
    {
      Crusts = new List<CrustModel>() { new CrustModel() { Name = "Regular" }};
      Sizes = new List<SizeModel>() { new SizeModel() { Name = "Medium" }};
      Toppings = new List<ToppingModel>() { new ToppingModel(){ Name = "Pepperoni" }};

    }
    public PizzaViewModel(List<CrustModel> crustModels, List<SizeModel> sizeModels, List<ToppingModel> toppingModels)
    {
      Crusts = crustModels;
      Sizes = sizeModels;
      Toppings = toppingModels;

    }
  }

  public class CheckBoxTopping : ToppingModel
  {
    public string Text { get; set; }
    public bool IsSelected { get; set; }
  }
}
