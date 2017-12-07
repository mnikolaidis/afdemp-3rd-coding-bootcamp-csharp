using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // The example tests which version of ShowDetails is called.The following method, TestCars1, declares an instance of each class, 
            // and then calls DescribeCar on each instance.
            System.Console.WriteLine("\nTestCars1");
            System.Console.WriteLine("----------");

            Car car1 = new Car();
            car1.DescribeCar();
            System.Console.WriteLine("----------");

            // Notice the output from this test case. The new modifier is  
            // used in the definition of ShowDetails in the ConvertibleCar  
            // class.    

            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();
            System.Console.WriteLine("----------");

            Minivan car3 = new Minivan();
            car3.DescribeCar();
            System.Console.WriteLine("----------");

            // Notice especially the results for car2, which probably are not what you expected. 
            // The type of the object is ConvertibleCar, but DescribeCar does not access the version of ShowDetails that is defined in the ConvertibleCar class because that method is declared with the new modifier, not the override modifier.
            // As a result, a ConvertibleCar object displays the same description as a Car object. Contrast the results for car3, which is a Minivan object.
            // In this case, the ShowDetails method that is declared in the Minivan class overrides the ShowDetails method that is declared in the Car class, and the description that is displayed describes a minivan.

            System.Console.WriteLine("----------");

            var cars = new List<Car> { new Car(), new ConvertibleCar(), new Minivan() };

            foreach (var car in cars)
            {
                car.DescribeCar();
                System.Console.WriteLine("----------");
            }
            // The ShowDetails method of the ConvertibleCar class is not called, regardless of whether the type of the object is ConvertibleCar, as in TestCars1, or Car, as in TestCars2. 
            // Conversely, car3 calls the ShowDetails method from the Minivan class in both cases, whether it has type Minivan or type Car.


        }
    }
}
