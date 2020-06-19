using Microsoft.Extensions.Hosting;

namespace CarRental.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Mail;
    using System.Threading.Tasks;

    using CarRental.Web.ViewModels.TransferReservation;
    using Microsoft.AspNetCore.Mvc;
    using SendGrid.Helpers.Mail;

    public class TransferReservation : BaseController
    {
        public IActionResult ChooseTransfer()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult TransferReservationForm(SendTransferInformationViewModel em)
        {
            string name = em.Name;
            string email = em.Email;
            string phoneNumber = em.PhoneNumber;
            string numberOfPersons = em.NumberOfPersons;
            string fromDestination = em.FromDestination;
            string toDestination = em.ToDestination;
            string address = em.Address;
            string date = em.Date;
            string time = em.Time;
            string comment = em.Comment;
            MailMessage mm = new MailMessage();
            mm.To.Add("eliscarbulgaria@gmail.com");
            mm.Subject = name;
            mm.Body = phoneNumber;
            mm.Body = numberOfPersons;
            mm.Body = fromDestination;
            mm.Body = toDestination;
            mm.Body = address;
            mm.Body = date;
            mm.Body = time;
            mm.Body = comment;
            mm.From = new MailAddress(email);
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("imap.gmail.com");
            smtp.Port = Convert.ToInt32(587);
            //smtp.Host = "imap.gmail.com";
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = Convert.ToBoolean(true);
            smtp.Credentials = new System.Net.NetworkCredential("eliscarbulgaria@gmail.com", "mastersan12!");
            smtp.Send(mm);
            this.ViewBag.message = "The Mail Has Been Sent To ElisCar Successfully ! We will contact you a few minutes later !";
            return this.View();
        }
    }
}
