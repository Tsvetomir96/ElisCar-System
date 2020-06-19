namespace CarRental.Web.ViewModels.TransferReservation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SendTransferInformationViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string NumberOfPersons { get; set; }

        public string FromDestination { get; set; }

        public string ToDestination { get; set; }

        public string Address { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Comment { get; set; }
    }
}
