using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
	public class StoreModel : AModel
	{
		public List<OrderModel> Orders { get; set;}
	}
}
