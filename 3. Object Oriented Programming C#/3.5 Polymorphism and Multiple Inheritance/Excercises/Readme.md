## Exercise 1
First, create a **base class** called **Shape**, and **derived classes** such as **Rectangle**, **Circle**, and **Triangle**. Give the Shape class a virtual method called **Draw**, and override it in each derived class to draw the particular shape that the class represents. Create a ```List<Shape>``` object and add a Circle, Triangle and Rectangle to it. To update the drawing surface, use a foreach loop to iterate through the list and call the Draw method on each Shape object in the list. Even though each object in the list has a declared type of Shape, it is the run-time type (the overridden version of the method in each derived class) that will be invoked.

## Exercise 2
A  derived class can override a base class member only if the base class member is declared as virtual or abstract. The derived member must use the override keyword to explicitly indicate that the method is intended to participate in virtual invocation. Create a BaseClass and a Derived Class to indicate the above statement by using two virtual methods.

## Exercise 3
Polymorphism and Function Overloading. You can have multiple definitions for the same function name in the same scope. The definition of the function must differ from each other by the types and/or the number of arguments in the argument list. You cannot overload function declarations that differ only by return type. Create a class with three methods that have the same name and demonstrate how they can act polymorphic.

## Exercise 4
Demonstrate the use of the Law of Demeter with an example in C#. Create three classes. The Wallet class just stores its amount and exposes two methods to manipulate this amount. A customer has a first name, last name and a wallet. And finally the paperboy sell its good to a given customer using its wallet. Identify the problems that come up when we develop these classes. Rewrite the code to fix issues following the Law of Demeter Design, increasing readability and maintainability without losing any functionality.

## Exercise 5
Define a ```class``` **Car** that implements the ```IEquitable<T>``` interface to check if two objects are equal.

## Exercise 6
Exercise Description: Create an Interface that contains property declaration (two integer properties) and a class that contains the implementation.

## Exercise 7
Define an **interface** (**ITransactions**) that contains two methods (**ShowTransaction**, **GetAmount**). Then create a class **Transaction** that implements this interface. This class should have two constructors in order to instantiate objects and take behavior from the interface. Create a simple scenario to play with the code you developed.