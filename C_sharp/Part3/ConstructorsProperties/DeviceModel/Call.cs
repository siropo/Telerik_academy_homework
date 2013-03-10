using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceModel
{
    public class Call
    {
        private DateTime dateCall;
        private uint number;
        private double callDuration;

        public Call(uint number, double callDuration) : this(DateTime.Now, number, callDuration)
        {

        }

        public Call(DateTime dateCall, uint number, double callDuration)
        {
            this.DateCall = dateCall;
            this.Number = number;
            this.CallDuration = callDuration;
        }

        public DateTime DateCall
        {
            get 
            { 
                return this.dateCall; 
            }
            private set
            {
                this.dateCall = value;
            }
        }

        public uint Number
        {
            get 
            {
                return this.number; 
            }
            private set 
            {
                this.number = value;
            }
        }

        public double CallDuration
        {
            get 
            {
                return this.callDuration; 
            }
            private set 
            {
                this.callDuration = value;
            }
        }
        
    }
}
