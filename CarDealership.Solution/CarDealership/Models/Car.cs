using System.Collections.Generic;

namespace CarDealership.Models
{
	public class Car
	{
		public string Model { get; set; }
		public int Price { get; set; }
		public int Miles { get; set; }
		private static List<Car> _instances = new List<Car>();

		public Car(string model, int price, int miles)
		{
			Model = model;
			Price = price;
			Miles = miles;
			_instances.Add(this);
		}

		public static List<Car> GetAll()
		{
			return _instances;
		}

		public static void ClearAll()
		{
			_instances.Clear();
		}
	}
}