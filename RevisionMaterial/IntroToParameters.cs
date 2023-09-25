using System;

class IntroToParameters 
{
  //These are 'global' variables which can be accessed throughout the program
  //A global variable must be declared using the static keyword
  static char gender;
  static string yearGroup;
  public static void Run(string[] args) 
  {
    //*******************************************************
    //*******************************************************
    //*********************METHODS- USING PARAMETERS******************
    //*******************************************************
    //*******************************************************

    // A method can sent variables to use as part of its execution
    // These parameters must be declared within the method signature and must include the 'type' i.e int, string etc and also a name
    string name;
    int age =0;
    Console.WriteLine("Using parameters in Methods");
    Console.WriteLine("What is your name");
    name=Console.ReadLine();

    Console.WriteLine("What is your age");
    age=Convert.ToInt16(Console.ReadLine());

    //This is a method call
    methodOne(name);
    methodTwo(name,age);
  }

  //This method specifies that it must be sent a string in order to be successfully 
  //The method signature is the everything inside the brackets after the method name
  //The data type, order and number of parameters are significant in a method signature
  //When calling a method, the method call must send exactly the same parameter types in the order in which they are specified in the method signature
  static void methodOne(string name)
  {
    Console.WriteLine("This is MethodOne, and your name is: " + name);
  }

  //This method specifies that it must be sent a string and an int variable in that order in order to successfully executed
  //The variable reference name specified in the method signature does not have to match the name of the variable sent  through the method call
  //In this example the string variable name is sent through  the method call in the main method yet it is called personsName in the method signature
  static void methodTwo(string name, int age)
  {
    Console.WriteLine("You are called, " + name + " and your age is " + age );
  }
}
