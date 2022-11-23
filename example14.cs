using System;

class Program {
  public static void Main (string[] args) { 
  int i=1;
  int max= -1;
  int num;
  do{
    num= Convert.ToInt32(Console.ReadLine());
    i++;
    if (num>max)
    {
      max=num;
    } 
  } while (i<=5);
  Console.WriteLine("Maximum is" + max);
  }
}
