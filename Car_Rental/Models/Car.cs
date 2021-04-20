using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Car_Rental.Models
{
    public class Car
    {
        [Key]
        public int CarID { set; get; }
        [JsonIgnore]
        public string Model { get; set; }
        [JsonIgnore]
        public string PictureURL { get; set; }
        [JsonIgnore]
        public string FuelType { get; set; }
        [JsonIgnore]
        public DateTime Fabrication_Date { get; set; }
        [JsonIgnore]
        public decimal PricePerDay { get; set; }
        public float AverageScore { get; set; }
        [JsonIgnore]
        public float Acceleration { get; set; }
        [JsonIgnore]
        public string TransmisionType { get; set; }
        [JsonIgnore]
        public bool ClimateControll { get; set; }

        [JsonIgnore]
        public CarCategory Category { get; set; }
        [JsonIgnore]
        public CarTypes Type { get; set; }
        [JsonIgnore]
        public ICollection<CarLocation> CarLocations { get; set; }
        [JsonIgnore]
        public ICollection<Reservation> Reservations { get; set; }

        public Car()
        {
            CarLocations = new HashSet<CarLocation>();
            Reservations = new HashSet<Reservation>();
        }
    }
}