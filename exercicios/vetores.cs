using System;
class Program{
  public static void Main(string[] args){
    /*int[] v = new int[5];
    Console.WriteLine($"Length = {v.Length}");
    for(int k=0; k<=4;k++){
      Console.WriteLine($"v[{k}] = {v[k]}");
    }*/
    int[,] w = new int[3,4];
    w[2,1]=5;
    Console.WriteLine("[1]   [2]    [3]   [4]");
    for(int l=0;l<3;l++){
      for(int c=0;c<4;c++)
        Console.Write($"{w[l,c]}      ");
      Console.WriteLine();
    }
    /*
    Console.WriteLine($"{w[0,0]}    ");
    Console.WriteLine($"{w[0,1]}    ");
    Console.WriteLine($"{w[0,2]}    ");
    Console.WriteLine($"{w[0,3]}    ");
    Console.WriteLine();
    Console.WriteLine($"{w[1,0]}    ");
    Console.WriteLine($"{w[1,1]}    ");
    Console.WriteLine($"{w[1,2]}    ");
    Console.WriteLine($"{w[1,3]}    ");
    Console.WriteLine();
    Console.WriteLine($"{w[2,0]}    ");
    Console.WriteLine($"{w[2,1]}    ");
    Console.WriteLine($"{w[2,2]}    ");
    Console.WriteLine($"{w[2,3]}    ");
    */

  }
}