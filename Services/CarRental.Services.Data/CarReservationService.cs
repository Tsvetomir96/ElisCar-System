namespace CarRental.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CarRental.Data.Common.Repositories;
    using CarRental.Data.Models;
    using CarRental.Services.Mapping;

    public class CarReservationService : ICarReservationService
    {
        private readonly IDeletableEntityRepository<Car> carReservationRepository;

        public CarReservationService(IDeletableEntityRepository<Car> carReservationRepository)
        {
            this.carReservationRepository = carReservationRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Car> query =
                this.carReservationRepository.All();
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }
    }
}