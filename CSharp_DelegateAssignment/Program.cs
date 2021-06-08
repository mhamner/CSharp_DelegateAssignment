using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DelegateAssignment
{
    delegate void MathDelegate(int numberA, int numberB);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Number A:");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Number B:");
            int numB = Convert.ToInt32(Console.ReadLine());

            //Create a new instance of our delegate
            MathDelegate mathDelegate;
            
            if(numA > numB)
            {
                mathDelegate = SubtractAB;
            }
            else
            {
                mathDelegate = SubtractBA;
            }

            mathDelegate += MultiplyAB;

            if(numA > 0 && numB > 0)
            {
                mathDelegate += DivideAB;
                mathDelegate += DivideBA;
            }

            //Execute all the chained-together delegates
            mathDelegate(numA, numB);

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }

        static void SubtractAB(int numberA, int numberB)
        {
            Console.WriteLine($"{numberA} - {numberB} = {numberA - numberB}.");
        }

        static void SubtractBA(int numberA, int numberB)
        {
            Console.WriteLine($"{numberB} - {numberA} = {numberB - numberA}.");
        }

        static void MultiplyAB(int numberA, int numberB)
        {
            Console.WriteLine($"{numberA} * {numberB} = {numberA * numberB}.");
        }

        static void DivideAB(int numberA, int numberB)
        {
            Console.WriteLine($"{numberA} / {numberB} = {numberA / numberB}.");
        }

        static void DivideBA(int numberA, int numberB)
        {
            Console.WriteLine($"{numberB} / {numberA} = {numberB / numberA}.");
        }
    }
}
