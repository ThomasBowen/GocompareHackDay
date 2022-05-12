using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Models
{
    public class VehicleModel
    {
        public string abiCode { get; set; }
        public int numberOfDoors { get; set; }
        public int numberOfSeats { get; set; }
        public string transmissionType { get; set; }
        public int transmissionId { get; set; }
        public int yearOfManufacture { get; set; }
        public int auctionSale { get; set; }
        public int forecourtSale { get; set; }
        public int privateSale { get; set; }
        public int tradeIn { get; set; }
        public object grossWeight { get; set; }
        public int payload { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public int manufacturedFrom { get; set; }
        public int manufacturedTo { get; set; }
        public string makeDescription { get; set; }
        public string modelDescription { get; set; }
        public int engineCc { get; set; }
        public string bodyType { get; set; }
        public string fuelType { get; set; }
        public string vehicleType { get; set; }
        public int securityId { get; set; }
        public string alarmImmobiliserCode { get; set; }
    }
}
