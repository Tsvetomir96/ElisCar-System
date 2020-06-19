namespace CarRental.Web.ViewModels.CarReservation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CarModelViewModel
    {
        public IEnumerable<CarPropertiesViewModel> CarsModels { get; set; }
    }
}
