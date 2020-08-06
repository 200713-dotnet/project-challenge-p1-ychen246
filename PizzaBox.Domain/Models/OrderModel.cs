using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
	public class OrderModel : AModel
	{
		public List<PizzaModel> Pizzas { get; set;}

		//public UserModel user { get; set;} 
		//public StoreModel store { get; set;}
		//Might need.

		public decimal OrderPrice {
			get 
			{
				decimal TotalOrderSum = 0;
				foreach (var p in Pizzas)
				{
					TotalOrderSum += p.PizzaPrice;
				}
				return TotalOrderSum;
			}
		}
	}
}
