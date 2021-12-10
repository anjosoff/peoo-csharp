using System;
class MainClass{
  public static void Main(string[] args){
    Retangulo x = new Retangulo();

    Console.WriteLine("Entre com o valor da Altura:");
    x.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine("Entre com o valor da Base:");
    x.SetBase(double.Parse(Console.ReadLine()));
    Console.WriteLine(x.ToString());
    Console.WriteLine($"Área:"+x.CalcArea());
    Console.WriteLine($"Diagonal:"+x.CalcDiagonal());
    
  }
}
class Retangulo {
  private double b;
  private double h;
  public void SetBase(double vb){
    if(vb>0) b=vb;
  }
  public void SetAltura(double vh){
    if(vh>0) h=vh;
  }
  public double GetAltura(){
    return h;
  }
  public double GetBase(){
    return b;
  }
  public double CalcArea(){
    double area;
    area=(b*h);
    return area;
  }
  public double CalcDiagonal(){
    double diagonal,b1,h1;
    h1=Math.Pow(h,2);
    b1=Math.Pow(b,2);
    diagonal=b1+h1;
    diagonal=Math.Sqrt(diagonal);
    return diagonal;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
}
}