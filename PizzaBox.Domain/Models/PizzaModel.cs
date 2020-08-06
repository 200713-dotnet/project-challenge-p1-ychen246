using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
	public class PizzaModel : AModel
	{
		public CrustModel Crust { get; set; }
		public SizeModel Size { get; set; }
		public List<ToppingModel> Toppings { get; set; }

		public decimal PizzaPrice
		{
			get
			{
				decimal ToppingPriceSum = 0;
				foreach (var t in Toppings)
				{
					ToppingPriceSum += t.Price;
				}
				return Crust.Price + Size.Price + ToppingPriceSum;
			}
			set{}
		}
	}
}
