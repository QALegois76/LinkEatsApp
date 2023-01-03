// See https://aka.ms/new-console-template for more information

using ConsoleAppEntityFramework.Models;

namespace ConsoleAppEntityFramework
{
	public class DatabaseMng
	{
		private static DatabaseMng _instance;

		public static DatabaseMng Instance => _instance ?? (_instance = new DatabaseMng());

		private EFContext _context;

		private ClientMng _clientMng;
		private RestaurantMng _restaurantMng;
		private DeliverymanMng _deliveryMng;
		private OrderMng _orderMng;
		private DiscountMng _discountMng;


		public ClientMng Clients => _clientMng;
		public RestaurantMng Restaurants => _restaurantMng;
		public DeliverymanMng Deliveryman => _deliveryMng;
		public OrderMng OrderMng => _orderMng;
		public DiscountMng DiscountMng => _discountMng;


		private DatabaseMng()
		{
			_context = new EFContext();

			_clientMng = new ClientMng(_context.Client);
			_restaurantMng = new RestaurantMng(_context.Restaurants);
			_deliveryMng = new DeliverymanMng(_context.Deliverymen);
			_orderMng = new OrderMng(_context.Orders);
			_discountMng = new DiscountMng(_context.Discounts);

			_clientMng.OnSaveData += EntityMng_OnSaveData;
			_restaurantMng.OnSaveData += EntityMng_OnSaveData;
			_deliveryMng.OnSaveData += EntityMng_OnSaveData;
			_orderMng.OnSaveData += EntityMng_OnSaveData;
			_discountMng.OnSaveData += EntityMng_OnSaveData;
		}

		private void EntityMng_OnSaveData(object? sender, EventArgs e) => Save();

		public void Save() => _context.SaveChanges();

	}
}

