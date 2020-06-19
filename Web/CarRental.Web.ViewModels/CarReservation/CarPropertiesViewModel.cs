namespace CarRental.Web.ViewModels.CarReservation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CarRental.Data.Models;
    using CarRental.Services.Mapping;

    public class CarPropertiesViewModel : IMapFrom<Car>
    {
        public string CarModel { get; set; }

        public string CarImage { get; set; }

        public string CarDescription { get; set; }

        public int CarPricePerDay { get; set; }

        public string Url => $"/c/{this.CarModel.Replace(' ', '-')}";
    }
}
