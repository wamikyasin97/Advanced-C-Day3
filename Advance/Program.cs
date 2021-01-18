using System;
using System.IO;

namespace Advance
{
    //Interface
    interface IfirstMethod
    {
        void method();
    }

    interface IsecondMethod
    {
        void otherMethod();
    }

    class demoMethod : IfirstMethod, IsecondMethod
    {
        public void method()
        {
            Console.WriteLine("This is method from first class");
        }

        public void otherMethod()
        {
            Console.WriteLine("This is method from second class");
        }
    }

    //Abstract Class
    abstract class Animal
    {
        public abstract void animalSound();
        
        public void sleep()
        {
            Console.WriteLine("Sleeping......");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Barking!");
        }
    }

    //Polymorphism and Inheritance
    class Vehicle
    {
        public string type;
        public virtual void honk()
        {
            Console.WriteLine("Car is honking ");
        }
    }

    class Car : Vehicle
    {
        public string name;
        public string color;
        public int maxSpeed;
        //private string model;
        public string Model
        {
            get; //{ return model; }
            set; //{ model = value; }
        }

        public Car(string carName, string carColor, int carMaxSpeed)
        {
            name = carName;
            color = carColor;
            maxSpeed = carMaxSpeed;
        }

        public void fullSpeed()
        {
            Console.WriteLine($"{name} has achieved its maximum speed limit");
        }

        public override void honk()
        {
            Console.WriteLine($"{name} is honking");
        }
    }

    class Program
    {
        //Enum 
        enum Months
        {
            January,
            Feburary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static int MyMethod(string name, int n1, int n2)
        {
            Console.WriteLine("Hello World! \nfrom " + name);
            return n1 + n2;
        }

        static double MyMethod(string name, double n1, double n2)
        {
            Console.WriteLine("Hello World! \nfrom " + name);
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            //Functions
            string fullName = "Wamik Yasin";
            Console.WriteLine(MyMethod(fullName, 2, 8));
            Console.WriteLine(MyMethod(fullName, 3.6, 8.4));

            //Classes/Objects
            Car BMW = new Car("BMW", "Blue", 300);
            BMW.type = "Sedan";
            BMW.Model = "5 Series";
            Console.WriteLine($"Type of the car is {BMW.type}");
            Console.WriteLine($"Model of the car is {BMW.Model}");
            Console.WriteLine($"Color of the car is {BMW.color}");
            Console.WriteLine($"Maximum speed of the car is {BMW.maxSpeed}");
            BMW.honk();
            BMW.fullSpeed();
            

            Car Honda = new Car("Honda", "White", 260);
            Honda.type = "Hatchback";
            Honda.Model = "Accord";
            Console.WriteLine($"Type of the car is {Honda.type}");
            Console.WriteLine($"Model of the car is {Honda.Model}");
            Console.WriteLine($"Color of the car is {Honda.color}");
            Console.WriteLine($"Maximum speed of the car is {Honda.maxSpeed}");
            Honda.honk();
            Honda.fullSpeed();

            Vehicle VW = new Vehicle();
            VW.honk();

            Vehicle XY = new Car("XYZ", "Black", 200);
            XY.honk();

            Dog myDog = new Dog();
            myDog.animalSound();
            myDog.sleep();

            demoMethod myDemoMethod = new demoMethod();
            myDemoMethod.method();
            myDemoMethod.otherMethod();

            Months myMonth = Months.April;
            Console.WriteLine(myMonth);
            int number = Convert.ToInt32(Months.April);
            Console.WriteLine(number);

            //File Method
            string writeText = "Hello World";
            File.WriteAllText("draft.txt", writeText);

            string readText = File.ReadAllText("draft.txt");
            Console.WriteLine(readText);

            //Try Catch Error
            try
            {
                int[] numbers = { 0, 1, 2 };
                Console.WriteLine(numbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done with the whole coding")
;            }
        }
    }
}
