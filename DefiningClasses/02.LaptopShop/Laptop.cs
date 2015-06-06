using System;
using System.Text;

namespace _02.LaptopShop
{
    class Laptop
    {
        //FIELDS
        private string model;
        private decimal price;

        //CONSTRUCTORS
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer)
            :this(model, price)
        {
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor)
            :this(model, price, manufacturer)
        {
            this.Processor = processor;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram)
            :this(model, price, manufacturer, processor)
        {
            this.RAM = ram;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, 
            string graficsCard) 
                : this(model, price, manufacturer, processor, ram)
        {
            this.GraphicsCard = graficsCard;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram,
            string graficsCard, string hdd)
            : this(model, price, manufacturer, processor, ram, graficsCard)
        {
            this.HDD = hdd;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram,
            string graficsCard, string hdd, string screen)
            : this(model, price, manufacturer, processor, ram, graficsCard, hdd)
        {
            this.Screen = screen;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram,
            string graficsCard, string hdd, string screen, Battery battery)
            : this(model, price, manufacturer, processor, ram, graficsCard, hdd, screen)
        {
            this.Battery = battery;
        }

        //PROPARTIES
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("model", "Model can't be empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer { get; set; }

        public string Processor { get; set; }

        public string RAM { get; set; }

        public string GraphicsCard { get; set; }

        public string HDD { get; set; }

        public string Screen { get; set; }

        public Battery Battery { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentException("price", "Price can't be negative");
                }
                this.price = value;
            }
        }

        //METHODS
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Sample laptop description:");
            result.AppendFormat("model: {0}\n", this.model);
            if (!string.IsNullOrWhiteSpace(this.Manufacturer))
            {
                result.AppendFormat("manufacturer: {0}\n", this.Manufacturer);
            }
            if (!string.IsNullOrWhiteSpace(this.Processor))
            {
                result.AppendFormat("processor: {0}\n", this.Processor);
            }
            if (!string.IsNullOrWhiteSpace(this.RAM))
            {
                result.AppendFormat("RAM: {0}\n", this.RAM);
            }
            if (!string.IsNullOrWhiteSpace(this.GraphicsCard))
            {
                result.AppendFormat("graphics card: {0}\n", this.GraphicsCard);
            }
            if (!string.IsNullOrWhiteSpace(this.HDD))
            {
                result.AppendFormat("HDD: {0}\n", this.HDD);
            }
            if (!string.IsNullOrWhiteSpace(this.Screen))
            {
                result.AppendFormat("screen: {0}\n", this.Screen);
            }
            if (this.Battery != null)
            {
                result.AppendFormat("battery: {0}\n", this.Battery.BatteryDesc);
                result.AppendFormat("battery life: {0} hours\n", this.Battery.BatteryLife);
            }
            result.AppendFormat("price: {0} lv.", this.Price);
            return result.ToString();
        }
    }
}
