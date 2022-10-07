using BoatBooking.Class;
using BoatBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BoatBooking.Controllers
{
    public class BookingController : Controller
    {
        private DataBase _dataBase = new DataBase();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boathouse()
        {
            BoathouseViewModel viewModel = new BoathouseViewModel();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddBoat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBoat(AddBoatViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            _dataBase.addBoatToDb(viewModel.name, viewModel.type, viewModel.minWeight, viewModel.maxWeight, viewModel.authorised);

            BoathouseViewModel boatHouseviewModel = new BoathouseViewModel();
            return View("Boathouse", boatHouseviewModel);
        }

        public IActionResult RemoveBoat(BoathouseViewModel b)
        {

            _dataBase.removeBoatFromDb(b.Boat.Name, b.Boat.type);

            BoathouseViewModel boatHouseviewModel = new BoathouseViewModel();
            return View("Boathouse", boatHouseviewModel);
        }

        public IActionResult AddReservation()
        {
            return View();
        }
    }
}
