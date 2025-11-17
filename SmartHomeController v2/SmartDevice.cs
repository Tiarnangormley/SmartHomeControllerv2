using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeController
{
    public class SmartDevice 
    {
        // Private fields
        private int deviceId;
        private string deviceName;
        private bool status;

        // Public properties
        public int DeviceID
        {
            get { return deviceId; }
            set { deviceId = value; }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public SmartDevice(int deviceID, string deviceName, bool status)
        {
            this.DeviceID = deviceID;
            this.DeviceName = deviceName;
            this.Status = false; // default status for a new smart item

        }

    public void TurnOn()
        {
            status = true;
            Console.WriteLine($"{deviceName} with {DeviceID} is now on");
        }

        public void TurnOff()
        {
            status = false;
            Console.WriteLine($"{deviceName} with {DeviceID} is now off");
        }

        public virtual void GetStatus()
        {
            Console.WriteLine($"DeviceID {DeviceID},Name:{DeviceName}, Status (On or Off); {(Status ? "ON" : "OFF")}");
        }
    }
}
