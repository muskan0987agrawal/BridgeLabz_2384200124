/* using System;

namespace Inheritance
{
    internal class Device
    {
        protected int DeviceID;
        protected string status;

        public void SetDeviceDetails(int DeviceID, string status)
        {
            this.DeviceID = DeviceID;
            this.status= status;
        }

        public void DisplayDetails()
        {
           
            Console.WriteLine($"DeviceId: {DeviceID} \tStatus: {status}");
        }
    }
    internal class Thermostat: Device
    {
        double TemperatureSetting;
        public void SetTemperatureSetting(int DeviceId,string status, double TemperatureSetting) {
            SetDeviceDetails(DeviceID, status);
            this.TemperatureSetting = TemperatureSetting;
        }

        public void DisplayStatus()
        {
            DisplayDetails();
            Console.WriteLine($"Temperature Setting: {TemperatureSetting}");
        }

    }
    internal class Program5
    {
        public static void Main(string[] args)
        {
            Device device = new Device();
            device.SetDeviceDetails(101, "Online");
            Console.WriteLine("Displaying the Device Details: ");
            device.DisplayDetails();

            Console.WriteLine("");
            Thermostat thermostat = new Thermostat();
            thermostat.SetTemperatureSetting(202, "Active", 22.5);
            Console.WriteLine("Displaying the Thermostat Details: ");
            thermostat.DisplayStatus();
        }

    }
}
*/