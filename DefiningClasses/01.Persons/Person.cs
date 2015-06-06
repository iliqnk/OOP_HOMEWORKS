using System;

namespace _01.Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            :this(name, age, null)
        {
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Invalid age!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new Exception("Invalid email!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Person's name: {0}\nPerson's Age: {1}\nPerson's email: {2}\n",
                this.name, this.age, this.email ?? "no email address yet submitted");
        }
    }
}
