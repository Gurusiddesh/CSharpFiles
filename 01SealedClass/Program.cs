using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class A
    {

    }

    sealed class B : A  //Using Sealed keyword we can restrict Inheritence of class B to Any other class; 
    {

    }

    class C : B //Error in Class Inheritence;
    {

    }
}
