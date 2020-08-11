using PizzaBox.Client;
using PizzaBox.Domain.Factories;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaFactoryTest
  {
    [Fact]
    public void PizzaFactory()
    {
      PizzaFactory sut = new PizzaFactory();
      var actual = sut.Create();

      Assert.NotNull(actual);
    }
  }
}