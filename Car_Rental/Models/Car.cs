using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental.Models
{
    public class Car
    {
        [Key]
        public int CarID { set; get; }
        public string Model { get; set; }
        public string PictureURL { get; set; }
        public string FuelType { get; set; }
        public DateTime Fabrication_Date { get; set; }
        public decimal PricePerDay { get; set; }
        public float AverageScore { get; set; }
        public float Acceleration { get; set; }
        public string TransmisionType { get; set; }
        public bool ClimateControll { get; set; }

        public CarCategory Category { get; set; }
        public CarTypes Type { get; set; }
        public ICollection<CarLocation> CarLocations { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

        public Car()
        {
            CarLocations = new HashSet<CarLocation>();
            Reservations = new HashSet<Reservation>();
        }
    }
}