using System;
class Program{
  public static void Main(String[] args){
    Triangulo x= new Triangulo();
    Triangulo y= new Triangulo();
    x.b=20;
    x.h=10;
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(x.CalcArea());
  }
}
class Triangulo{
  public double b,h;
  public Triangulo(){

  }
  public Triangulo(double b, double h){
    if(b>0)b=this.b;
    if(h>0)h=this.h;
  }
  public double CalcArea(){
    return this.b*this.h/2;
  }
}