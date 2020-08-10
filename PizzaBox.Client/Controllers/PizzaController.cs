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
  }
}
