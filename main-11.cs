using System;

class Program {
  public static void Main (string[] args) { 
  int sum=0;
  int num= Convert.ToInt32(Console.ReadLine());
  while (num!=-999)
  {
    if(num%2!=0)
    {
      sum+=num;
    }
  num= Convert.ToInt32(Console.ReadLine());
  }
    Console.WriteLine (sum);  
  }
}