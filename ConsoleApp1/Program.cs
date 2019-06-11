using System;

namespace ConsoleApp1
{

    class sample
    {
        public void Show()
        {
            Console.WriteLine("hi this is my first program");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample sap = new sample();
            sap.Show();
        }
    }
}
