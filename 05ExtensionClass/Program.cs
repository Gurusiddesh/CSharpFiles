using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ExtensionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String s = "hello";
            string result =s.DigittoString(4);
            Console.WriteLine(result);
        }
    }

        public static class Demo
        {
            public static String DigittoString(this String s, int n)
            {
                switch(n)
                {
                    case 1:
                        return "One";
                    case 2:
                        return "Two";
                    case 3:
                        return "Three";
                    case 4:
                        return "Four";
                    case 5:
                        return "Five";
                    case 6:
                        return "Six";
                    case 7:
                        return "Seveen";
                    case 8:
                        return "Eight";
                    case 9:
                        return "Nine";
                    case 0:
                        return "Zero";
                    default:
                        return "Invalid";


                }
            }
        }
    }

