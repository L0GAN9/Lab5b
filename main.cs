using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("How many Cars?");
    var c = Convert.ToInt32(Console.ReadLine());
    int counter=0;
    double total = 0;
    while(counter < c)
    {
      Console.Write("Enter Distance Covered By Car ");
      Console.WriteLine(counter+1);
      var x = Console.ReadLine();
      double distance = Convert.ToDouble(x);

      Console.Write("Enter Time Taken By Car ");
      Console.WriteLine(counter+1);
      var y = Console.ReadLine();
      double time = Convert.ToDouble(y);

      Console.Write("The Speed of This Car is ");
      Console.Write(distance/time);
      Console.WriteLine(" Miles Per Hour");
      var av = (distance/time);
      total = total + (av);
      
      
      counter++;
    }
    double average = total / c;
    Console.Write("Average Speed of Cars is ");
    Console.Write(average);
    Console.WriteLine(" Miles Per Hour");
  }
}