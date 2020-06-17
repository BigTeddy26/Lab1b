using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter your first number.");
    var x = Console.ReadLine();

    Console.WriteLine ("Please enter your second number.");
    var y = Console.ReadLine();

    int x1 = Convert.ToInt32(x);

    int y1 = Convert.ToInt32(y);

    Console.WriteLine ("The sum of the two numbers is " + (x1+y1));
    Console.WriteLine ("The difference of the two numbers is " + (x1-y1));
    Console.WriteLine ("The product of the two numbers is " + (x1*y1));
    Console.WriteLine ("The quotient of the two numbers is " + (x1/y1));
    Console.WriteLine ("The remainder is " + (x1%y1));
  }
}