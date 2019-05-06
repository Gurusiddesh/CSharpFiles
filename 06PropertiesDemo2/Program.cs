using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PropertiesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.City = "Goa";
            // City is a write only property
            // Console.WriteLine(d.City);

            // Phone is a read only property
            // d.Phone = "";
            Console.WriteLine(d.Phone);

            // private set property
            // d.Name = "Ramu";
            Console.WriteLine(d.Name);

            d.IsMarried = true;
            // private get property
            // Console.WriteLine(d.IsMarried);
        }
    }
    class Demo
    {
        private int id;
        private string name;
        private string phone;
        private string city;
        private bool isMarried;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string City  // write only property
        {
            set { city = value; }
        }
        public string Phone  // Phone read only property
        {
            get { return phone; }
        }
        public string Name //Name is Private set property only class member
        {
           private set { name = value; }
            get { return name; }
        }
        public bool IsMarried
        {
            set { isMarried = value; }
            private get { return isMarried; }
        }
    }

}
