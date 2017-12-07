using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Car : IEquatable<Car>
    {
        private string Brand;

        public Car(string brand)
        {
            Brand = brand;
        }
        public bool Equals(Car other)
        {
            if (other == null)
            {
                return false;
            }

            return Brand == other.Brand ? true : false;
        }
    }
}
