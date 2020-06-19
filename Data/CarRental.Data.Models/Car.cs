namespace CarRental.Data.Models
{
    using CarRental.Data.Common.Models;

    public class Car : BaseDeletableModel<int>
    {
        public string CarModel { get; set; }

        public string CarImage { get; set; }

        public string CarDescription { get; set; }

        public int CarPricePerDay { get; set; }
    }
}
