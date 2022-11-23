using System;

class Program {
  public static void Main (string[] args) {
    int n=4; //initialization
    for(int i=1; i<=n; i++) //outer loop
    {
      for (int j=1; j<=8;j++) //inner loop
      {
      Console.WriteLine("*");
      }
      Console.WriteLine();
    }

  
  }
}