using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
	public class UserModel : AModel
	{
		public List<OrderModel> Orders { get; set;}
	}
}
