using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceModel
{
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery() : this(null)
        {

        }

        public Battery(string model) 
            : this(model, 0)
        {

        }

        public Battery(string model, double hoursIdle)
            : this(model, hoursIdle, 0)
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
            : this(model, hoursIdle, hoursTalk, BatteryType.Unknown)
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

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

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }
        
    }
}
