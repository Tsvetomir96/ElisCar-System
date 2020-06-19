namespace CarRental.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CarRental.Services.Data;
    using CarRental.Web.ViewModels.CarReservation;
    using Microsoft.AspNetCore.Mvc;

    public class CarReservationController : BaseController
    {
        private readonly ICarReservationService carReservationService;

        public CarReservationController(ICarReservationService carReservationService)
        {
            this.carReservationService = carReservationService;
        }

        public IActionResult ChooseCar()
        {
            var viewModel = new CarModelViewModel
            {
                CarsModels = this.carReservationService.GetAll<CarPropertiesViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
