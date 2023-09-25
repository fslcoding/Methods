using System;

class IntroToMethods {
  public static void Run(string[] args) 
  {
    //*******************************************************
    //*******************************************************
    //*********************INTRO TO METHODS******************
    //*******************************************************
    //*******************************************************

    Console.WriteLine ("Introduction to methods");

    MethodOne();
    MethodTwo();
    MethodOne();

    for(int i = 0; i < 5; i++ )
    {
      MethodTwo();
    }

    Console.WriteLine("This is the ENDDDDDD!");
  }

  static void MethodOne()
  {
    Console.WriteLine("This is the first method");
  }

  static void MethodTwo()
  {
    Console.WriteLine("This is second method");
  }
}
