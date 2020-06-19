namespace CarRental.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICarReservationService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
