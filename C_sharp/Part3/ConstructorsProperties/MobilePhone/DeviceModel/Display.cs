using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceModel
{
    public class Display
    {
        private double size;
        private uint colors;

        public Display(double size, uint colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be negative."); 
                }
                this.size = value;
            }
        }

        public uint Colors
        {
            get
            {
                return this.colors;
            }
            private set
            {
                this.colors = value;
            }
        }
    }
}
