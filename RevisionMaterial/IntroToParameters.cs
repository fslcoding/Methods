using System;

class IntroToParameters 
{
  public static void Run(string[] args) 
  {
    //*******************************************************
    //*******************************************************
    //***************METHODS- USING PARAMETERS***************
    //*******************************************************
    //*******************************************************

    string name;
    int age;


    Console.WriteLine("What is your name?");
    name = Console.ReadLine();

    Console.WriteLine("What is your age?");
    age = Convert.ToInt16(Console.ReadLine());

    methodOne(name);

    methodTwo(name,age);

  }

  static void methodOne(string name)
  {
    Console.WriteLine("This is MethodOne, and your name is: " + name);
  }

  static void methodTwo(string name, int age)
  {
    Console.WriteLine("You are called, " + name + " and your age is " + age );
  }
}
