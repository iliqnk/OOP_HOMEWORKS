using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.PCCatalog
{
    class Computer: IComparable
    {
        //fields
        private string name;
        private List<Component> components;

        //constructors
        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        //properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "name can't be empty.");
                }
                this.name = value;
            }
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("components", "components should be atleast one.");
                }
                this.components = value;
            }
        }

        public decimal ComputerPrice
        {
            get
            {
                return CalculatePCPrice(this);
            }
        }
        
        //methods
        public int CompareTo(object obj)
        {
            Computer computer = (Computer) obj;
            return this.ComputerPrice.CompareTo(computer.ComputerPrice);
        }

        public decimal CalculatePCPrice(Computer computer)
        {
            var components = computer.Components;
            
            return components.Sum(component => component.Price);
        }

        public void AddComponent(Component component)
        {
            var componentsList = this.Components;
            componentsList.Add(component);
            this.Components = componentsList;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Computer Description");
            result.AppendFormat("Name: {0}\n", this.Name);
            result.AppendLine("Components:");
            foreach (var component in this.Components)
            {
                result.AppendFormat("\t{0}{2} ({1:c2})\n",
                    component.Name, component.Price, 
                    string.IsNullOrWhiteSpace(component.Details) ? "" : ":" + component.Details);
            }
            result.AppendFormat("Total Price: {0:c2}\n", this.ComputerPrice);
            return result.ToString();
        }
    }
}
