using System;

namespace _02.LaptopShop
{
    class Battery
    {
        private string batteryDesc;
        private double batteryLife;

        public Battery(string batteryDesc, double batteryLife)
        {
            this.BatteryDesc = batteryDesc;
            this.BatteryLife = batteryLife;
        }

        public string BatteryDesc
        {
            get { return this.batteryDesc; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("batteryDesc", "Battery description can't be empty");
                }
                this.batteryDesc = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("batteryLife", "Battery life can't be negative");
                }
                this.batteryLife = value;
            }
        }
    }
}
