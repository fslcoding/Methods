using System;

class IntroToMethods {
  public static void Run(string[] args) 
  {
    //*******************************************************
    //*******************************************************
    //*********************INTRO TO METHODS******************
    //*******************************************************
    //*******************************************************

    // A method is block of code that can be called on to perform a specific function over and over again
    // A method exists outside the MAIN method
    // A method will always begin with the keywords static void
    // A method will return the 'power of execution' to the main method

    Console.WriteLine ("Introduction to methods");
    MethodOne();//This will 'call' the printMe() to run
    MethodTwo();// This will 'call' the noPrintMe() method to run
    MethodOne();//This will 'call' the printMe() to run
    for(int i =0;i<5;i++)
    {
      MethodTwo();
    }
    Console.WriteLine("This is the ENDDDDDD!");
    
  }

  //This method will run and then return control to the main method
  static void MethodOne()
  {
    Console.WriteLine("This is the first method");
  }

  //This method will run and then return control to the main method
  static void MethodTwo()
  {
    Console.WriteLine("This is second method");
  }
}
