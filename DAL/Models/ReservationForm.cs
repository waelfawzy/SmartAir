using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    //ParkingPlaceLevel ,ParkingPlaceNumber
    //pcrResult,Description,PcrTypeId, LabId
    //Seats Numbers,IsThereDisability,DisabilityDescription
    //TotalPrice,ReceivedMethod,Order Status
    public class ReservationForm
    {
        public int Id { set; get; }
        public DateTime InsertionDate { set; get; } = DateTime.Now;


        [ForeignKey("Field")]
        public int FieldId { set; get; }

        [ForeignKey("Reservation")]
        public int ReservationId { set; get; }
        public string FieldValue { set; get; }
        public Reservation Reservation { set; get; }
        public Field Field { set; get; }
    }
}
