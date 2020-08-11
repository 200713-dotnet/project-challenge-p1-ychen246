using PizzaBox.Domain.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Storing.Repositories
{
	public class OrderRepository
	{
		private PizzaBoxDbContext _db;

		public OrderRepository(PizzaBoxDbContext context) 
		{
      		_db = context;
    	}

		public void UserOrder(StoreModel store, UserModel user, OrderModel order)
		{
			var newStore = _db.Stores.FirstOrDefault( s => s.Name == store.Name);
      		var newUser = _db.Users.FirstOrDefault ( u => u.Name == user.Name);
			//Temp Solution
			if(newStore.Orders == null)
			{
				newStore.Orders = new List<OrderModel>();
			}
			if(newUser.Orders == null)
			{
				newUser.Orders = new List<OrderModel>();
			}
			//
			newStore.Orders.Add(order);
			newUser.Orders.Add(order);

			_db.Stores.Update(newStore);
			_db.SaveChanges();

			_db.Users.Update(newUser);
			_db.SaveChanges();
		}

	}
}