namespace CarRental.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CarRental.Data.Models;
    using CarRental.Services.Mapping;

    public class IndexCarViewModel : IMapFrom<Car>
    {
        public string CarModel { get; set; }

        public string CarImage { get; set; }

        public string CarDescription { get; set; }

        public int CarPricePerDay { get; set; }

        public string Url => $"/c/{this.CarModel.Replace(' ', '-')}";
    }
}
