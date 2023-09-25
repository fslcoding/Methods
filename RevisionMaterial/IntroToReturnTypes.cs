using System;

class IntroToReturnTypes {
  public static void Run(string[] args) 
  {
    Console.WriteLine ("Methods with return types");
    int num1, num2;

    Console.WriteLine("Please enter number 1:");
    num1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Please enter number 2:");
    num2 = Convert.ToInt16(Console.ReadLine());
    int num3 = addition(num1, num2);
    Console.WriteLine("The sum of the two numbers " + num1 +" and " + num2 + " is " +  num3);

  }

  static int addition(int num1, int num2)
  {
    return num1 + num2;
  }
}
