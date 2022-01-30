using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Reservation
    {
        public int Id { set; get; }
        public DateTime ReservationDate { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;
        public int NumberOfPassengers { set; get; }
        public string Rating { set; get; }
        public string Comment { set; get; }

        [ForeignKey("ReservationType")]
        public int ReservationTypeId { set; get; }

        [ForeignKey("PaymentType")]
        public int PaymentTypeId { set; get; }
        public string PaymentStatus { set; get; }
        public decimal PaymentAmount { set; get; }
        [ForeignKey("Currency")]
        public int CurrencyId { set; get; }
        public Currency Currency { set; get; }
        [ForeignKey("User")]
        public int UserId { set; get; }

        [ForeignKey("StatusType")]
        public int StatusTypeId { set; get; }
        public ReservationType ReservationType { set; get; }
        public PaymentType PaymentType { set; get; }
        public StatusType StatusType { set; get; }
        public ICollection<ReservationForm> reservationForms { set; get; }


    }
}
