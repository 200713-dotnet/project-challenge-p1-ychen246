using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
	public class OrderModel : AModel
	{
		public List<PizzaModel> Pizzas { get; set;}

		public decimal OrderPrice 
		{
			get 
			{
				decimal TotalOrderSum = 0;
				foreach (var p in Pizzas)
				{
					TotalOrderSum += p.PizzaPrice;
				}
				return TotalOrderSum;
			}
			set{}
		}
	}
}
