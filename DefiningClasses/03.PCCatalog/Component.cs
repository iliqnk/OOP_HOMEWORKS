using System;

namespace _03.PCCatalog
{
    class Component: IComparable
    {
        //fields
        private string name;
        private decimal price;
        //constructors
        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details)
            : this(name, price)
        {
            this.Details = details;
        }
        //properties
        public string Details { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name can't be empty.");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0.00M)
                {
                    throw new ArgumentException("price", "price can't be negative.");
                }
                this.price = value;
            }
        }
        //methods
        public int CompareTo(object obj)
        {
            Component component = (Component) obj;
            return this.Price.CompareTo(component.price);
        }
    }
}
