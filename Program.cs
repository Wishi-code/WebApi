using System;
namespace MyApplication
{
    class Car
    {
        private string model;
        public string Model{
            get {return model;}
            set {model=value;}
        }
    }
    class Program
    {
        static void Main(string [] args)
        {
            Car myObj= new Car();
            myObj.Model="Corolla";
            Console.WriteLine(myObj.Model);
        }
    }

}