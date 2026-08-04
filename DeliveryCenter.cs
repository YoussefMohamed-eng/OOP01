using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    internal class DeliveryCenter
    {
        private Shipment[] Shipments = new Shipment[10];
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < Shipments.Length)
                    return Shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < Shipments.Length)
                    Shipments[index] = value;

            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in Shipments)
                {
                    if ((shipment != null) && (shipment.TrackingCode == trackingCode))
                        return shipment;
                }
                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipments.Length; i++) {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    return true;
                }

    }
            return false;
        }
    }
}
