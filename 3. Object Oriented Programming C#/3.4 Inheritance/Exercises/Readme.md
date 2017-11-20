# Exercises : Inheritance
## Exercise 2
1. Define an ```abstract class``` **Shape** with a ```protected``` member that describes the color of the shape. Create a ```public``` property that returns the color to the user. Also create two methods, a ```public``` method to set the color and an ```abstract``` to return the objects' info to the user.
3. Define a **derived** ```class``` Rectangle with two ```protected``` members for the width and the height of the rectangle. The Rectangle object must be immutable. Define a constructor to initialize the Rectange object. Create two public properties that return the width and the height to the user. Create a ```virtual``` method **GetArea** that calculates the total area of the Rectangle. Also implement the abstract method **GetInfo**. 
3. Create a **derived** ```class``` Square. This class extends the Rectangle ```class``` and cannot be inherited. Implement the **GetInfo** method to return the object info to the user.
4. Rectangle and Square classes must have a private field of type ```string``` that stores the objects' name (eg. Rectangle, Square).

## Exercise 3
We will create simple project to demonstrate inheritance. Imagine a shop that sells Computer Games. Every Computer Game has a **name** and a **price**. Every shop has a Stockroom where you can search a Computer Game by an ID. Computer Games can be divided into PC Games and Console Games. This two categories has its own special properties and override the way that they are being sold. PC Games are divided into Simulation and Adventure Games both having their special properties. Create a project where all this stuff happens and imagine a simple scenario in order to test your shop.  

## Exercise 5
Create a base class **Car** with two methods, **DescribeCar** and **ShowDetails**. Develop two classes that derive from **Car**, **ConvertibleCar** and **Minivan**. Use the method **ShowDetails** one time with the **new** keyword and one with **override**. Test the results on Main by creating objects and calling method ShowDetails.


