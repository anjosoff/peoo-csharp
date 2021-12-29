using System;
class MainClass{
  public static void Main(string[] args){
    Console.WriteLine(Func(12)*Func(14));
  }
  public static int Func(int n){
    return n+3-n%3;
  }
}