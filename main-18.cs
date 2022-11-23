using System;

class Program {
  public static void Main (string[] args) {
    int n=5; //initialization
    for(int i=1; i<=n; i++) //outer loop
    {
      for (int j=1; j<=i;j++) //inner loop
      {
      Console.Write("*");
      }
      Console.WriteLine();
    }

  
  }
}