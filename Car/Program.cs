using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string markname;
            string modelname;
            string regnum;
            string color;
            int odometer;
            int fueltank;

            public Car(string _modelname, string _markname,string _regnum, string _color)
            {
                modelname = _modelname;
                markname = _markname;
                regnum = _regnum;
                color = _color;
                odometer = 0;
                fueltank = 60;

                
                
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public int Fueltank
            {
                get { return fueltank; }
            }

            public void Info()
            { 
                Console.WriteLine($"Modelname: {modelname}. ");
                Console.WriteLine($"Markname: {markname}");
                Console.WriteLine($"Registration number: {regnum}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Current odometer:{Odometer}");
                Console.WriteLine($"Current fueltank:{Fueltank}");
            }
            
            public void Drive()
            {
                Console.WriteLine("'skrrrrrrrrrrt'");
                fueltank -= 5;
                odometer += 100;
            }
        }
        static void Main(string[] args)
        {
            Car mycar = new Car("modelname", "markname", "123AAA", "blue");
            Console.WriteLine($"Current odometer:{mycar.Odometer}");
            Console.WriteLine($"Current fueltank:{mycar.Fueltank}");
            while (mycar.Fueltank !=0)
            { 

                    mycar.Drive();
            }
            mycar.Info();
        }
    }
}
