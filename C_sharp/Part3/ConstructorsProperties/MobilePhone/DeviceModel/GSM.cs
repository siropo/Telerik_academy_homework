using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceModel
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private Battery battery;
        private Display display;

        // Call Histoty
        private List<Call> callHistory = new List<Call>();

        // The static filed
        static public GSM iphone = new GSM("IPhone");

        // Constructors
        public GSM()
        {

        }

        public GSM(string model)
            : this(model, "Unknown", 0.0m, null, null, null)
        {
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0.0m, null, null, null)
        {

        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {

        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // Properties

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }
        
        // Methods

        public void AddHistory(DateTime now, uint number, double callDuration)
        {
            Call newCall = new Call(now, number, callDuration);
            callHistory.Add(newCall);
        }

        public void DeleteHistory(int number)
        {
            callHistory.RemoveAt(number);
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        public decimal CalcPriceHistory(decimal pricePerMinet)
        {
            decimal allTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                allTime += (decimal)callHistory[i].CallDuration;
            }
            decimal totalPrice = pricePerMinet * (allTime / 60);
            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine("------------- GSM ----------------");
            toString.AppendLine("Model: " + this.Model);
            toString.AppendLine("Manufacturer: " + this.Manufacturer);
            toString.AppendLine("Owner: " + this.Owner);
            toString.AppendLine("Price: " + this.Price);
            if (this.Battery != null)
            {
                toString.AppendLine("Battery:");
                toString.AppendLine("Battery model: " + this.Battery.Model);
                toString.AppendLine("Battery hours talk: " + this.Battery.HoursTalk);
                toString.AppendLine("Battery hours idle: " + this.Battery.HoursIdle);
                toString.AppendLine("Battery type: " + this.Battery.BatteryType);
            }
            if (this.Display != null)
            {
                toString.AppendLine("Display:");
                toString.AppendLine("Display size: " + this.Display.Size);
                toString.AppendLine("Display colors: " + this.Display.Colors);
            }
            return toString.ToString();
        }
    }
}
