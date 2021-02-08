using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
	public class CarsController : Controller
	{
		[HttpGet("/cars")]
		public ActionResult Index()
		{
			List<Car> allCars = Car.GetAll();
			return View(allCars);
		}

		[Route("/cars/new")]
		public ActionResult CreateForm()
		{
			return View();
		}

		[HttpPost("/cars")]
		public ActionResult Create(string model)
		{
			Car newCar = new Car(model);
			return RedirectToAction("Index", newCar);
		}
	}
}