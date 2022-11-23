using System;

class Program {
  public static void Main (string[] args) {
    int n=3; //initialization
    for(int i=1; i<=n; i++) //outer loop
    {
      for (int j=1; j<=10;j++) //inner loop
      {
      Console.WriteLine( (i*j)+"\t");
      }
      Console.WriteLine();
    }

  
  }
}