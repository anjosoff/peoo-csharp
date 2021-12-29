using System;
class Program{
  public static void Main(string[] args){
    int[] v = new int[5];
    Console.WriteLine($"Length = {v.Length}");
    for(int k=0; k<=4;k++){
      Console.WriteLine($"v[{k}] = {v[k]}");
    }
  }
}