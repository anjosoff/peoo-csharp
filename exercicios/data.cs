using System;
class MainClass{
  public static void Main(string[] args){
    int d,m,a;
    Data x = new Data();
    Console.WriteLine("Insira o dia:");
    d=int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o mês:");
    m=int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o ano:");
    a=int.Parse(Console.ReadLine());
    x.SetData(d,m,a);
    Console.WriteLine($"A data digitada foi dia "+x.GetDia()+" do mês "+x.GetMes()+" no ano de "+x.GetAno());
    Console.WriteLine(x.ToString());
  }
}
class Data{
  private int dia;
  private int ano;
  private int mes;
  public void SetData(int d, int m, int a){
    dia=d;
    ano=a;
    mes=m;
  }
  public int GetDia(){
    return dia;
  }
  public int GetMes(){
    return mes;
  }
  public int GetAno(){
    return ano;
  }
  public override string ToString() {
    return $"{dia}/{mes}/{ano}";
  }
}