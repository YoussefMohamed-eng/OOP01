using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    internal class Shipment
    {
        private string trackingCode;
        private string Description;
        private double Weight;
        private decimal DeliveryFee;
        public string TrackingCode
        {
            get { return trackingCode; }
        }
        public string description
        {
            get { return Description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    Description = value;
            }
        }
        public double weight
        {
            get
            {
                return Weight;
            }
            set
            {
                if (value > 0)
                    Weight = value;
            }
        }
        public decimal deliveryFee
        {
            get
            {
                return DeliveryFee;
            }
           private set
            {
                if (value > 0)
                    DeliveryFee = value;

            }
        }
        public DeliveryAddress Destination
        {
            get; set;
        }
        public decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (decimal)(weight * 5);
            }
        }
        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(string trackingCode,string Description,double Weight,decimal DeliveryFee,DeliveryAddress destination)
        {
            if(!string.IsNullOrWhiteSpace(trackingCode))
               this.trackingCode = trackingCode;
            description = Description;
            weight= Weight;
            deliveryFee= DeliveryFee;
            Destination= destination;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"TrackingCode : {TrackingCode} ");
            Console.WriteLine($"Description : {description} ");
            Console.WriteLine($"Weight : {weight} KG");
            Console.WriteLine($"DeliveryFee : {deliveryFee} EGP");
            Console.WriteLine($"Destination : {Destination.GetFullAddress()}");
            Console.WriteLine($"EstimatedCost : {EstimatedCost} EGP");
        }
    }
}
