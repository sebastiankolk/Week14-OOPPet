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

                Console.WriteLine($"{color});
                
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
            }
            public void GainMeter()
            {
                Console.WriteLine("'rrrrrrrrrrr'");
                odometer += 100;
            }
            public void Gas()
            {
                Console.WriteLine("'sss'");
                fueltank -= 5;
            }
        }
        static void Main(string[] args)
        {
            Car mycar = new Car("modelname", "markname", "123 AAA", "blue");
            while(mycar.Fueltank <0)
            { 
                    mycar.GainMeter();
                    mycar.Gas();
                    Console.WriteLine($"Current odometer:{mycar.Odometer}");
                    Console.WriteLine($"Current fueltank:{mycar.Fueltank}");
                
            }
            mycar.Info();
        }
    }
}
