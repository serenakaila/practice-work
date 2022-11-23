using System;

class Program {
  public static void Main (string[] args) { 
  int sum=0;
  int mark; int i=1;
  double average;
  while (i<=7)
  {
    mark= Convert.ToInt32(Console.ReadLine());
    sum +=mark;
    i++;
  }
  average= Convert.ToDouble(sum) /7;
  Console.WriteLine("Average= " + average);
  }
}