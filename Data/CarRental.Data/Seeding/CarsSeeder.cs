namespace CarRental.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarRental.Data.Models;

    public class CarsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cars.Any())
            {
                return;
            }

            var carDetails = new List<(string CarModel, string CarImage, string CarDescription, int CarPricePerDay)>
            {
                ("Volkswagen Golf", "https://wevee.uk/s/VW-E-Golf-from-WeVee.jpg", "description...", 20),
                ("Renault Clio", "https://gatesrentacar.com/wp-content/uploads/car-rental-gallery/1478617207_Clio.jpg", "description..", 15),
                ("Kia Rio", "https://s1.1zoom.me/b5349/962/KIA_Rio_Light_Blue_White_background_526267_3840x2160.jpg", "description...", 15),
                ("Mercedes Vito", "https://www.mbvans.com/content/dam/mb-vans/us/Awards/XXL_MB_VOW_D_ALG_Metris_Awards.jpg", "description...", 35),
                ("Ford Fiesta", "https://www.nicepng.com/png/detail/438-4385076_2019-ford-fiesta-2018-white-ford-fiesta-se.png", "description...", 15),
                ("Suzuki Ertiga", "https://s1.1zoom.me/big0/242/Suzuki_2018-19_Maruti_Ertiga_White_background_576511_1280x897.jpg", "description...", 20),
            };

            foreach (var details in carDetails)
            {
                await dbContext.Cars.AddAsync(new Car
                {
                    CarModel = details.CarModel,
                    CarImage = details.CarImage,
                    CarDescription = details.CarDescription,
                    CarPricePerDay = details.CarPricePerDay,
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
