using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.Details();
            s1.Print_Details();
            s1.Pay_Fees();
            s1.Transportation();
            s1.Calculate_Rank();
            s1.Dance();
            s1.Singing();

            Student2 s2 = new Student2();
            s2.Details();
            s2.Print_Details();
            s2.Pay_Fees();
            s2.Transportation();
            s2.Calculate_Rank();
            s2.Yoga();

           


        }
    }
    interface IDance
    {
        void Dance();
    }
    interface ISinging
    {
        void Singing();
    }
    interface IYoga
    {
        void Yoga();
    }

   abstract  class Student
    {
        int id,std,marks;
        string Name,dob, Address;

        public void Details()
        {
            Console.WriteLine("Enter the ID ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Class ");
            std = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Date Of Birth ");
            dob = Console.ReadLine();
            Console.WriteLine("Enter the Marks ");
            marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Address ");
            Address = Console.ReadLine();

        }

        public void Print_Details()
        {
            Console.WriteLine(id);
            Console.WriteLine(Name);
            Console.WriteLine(std);
            Console.WriteLine(dob);
            Console.WriteLine(marks);
            Console.WriteLine(Address);
            
        }

        public void Calculate_Rank()
        {
            float Rank;
            Rank = ((float)marks / 600)*100;

            if(Rank>70)
                Console.WriteLine("FCD");
            else if(Rank>60)
                Console.WriteLine("First Class");
            else
                Console.WriteLine("Second Class");
        }

        public abstract void Pay_Fees();
        public abstract void Transportation();
    }

    class Student1 : Student, IDance, ISinging
    {
        public override void Pay_Fees()
        {
            Console.WriteLine("Pays fees by Cash");
        }

        public override void Transportation()
        {
            Console.WriteLine("Comes to School By Bus");
        }
        public void Dance()
        {
            Console.WriteLine("Good in Dancing");
        }

        public void Singing()
        {
            Console.WriteLine("Good in Singing"); ;
        }
    }

    class Student2 : Student, IYoga
    {
        public override void Pay_Fees()
        {
            Console.WriteLine("Payees fees by Card");
        }

        public override void Transportation()
        {
            Console.WriteLine("Comes to School in Own Vechile");
        }

        public void Yoga()
        {
            Console.WriteLine("Good in Yoga");
        }
    }
}
