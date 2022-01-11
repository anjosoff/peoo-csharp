using System;

class Program {
  public static void Main () {
    Console.Write("Informe o número de países: ");
    int number = int.Parse(Console.ReadLine());
    Pais[] lista = new Pais[number];
    for(int i = 0; i< number;i++){
      Console.Write($"Informe o nome do {i+1}° país: ");
      string nome = Console.ReadLine();
      Console.Write($"Informe a população do {i+1}° país: ");
      int pessoas = int.Parse(Console.ReadLine());
      Console.Write($"Informe a área geográfica do {i+1}° país em km²: ");
      int area = int.Parse(Console.ReadLine());
      Pais novo = new Pais(nome, pessoas, area);
      lista[i] = novo;
    }
    int maior_pop = 0;
    int maior_area = 0;
    for(int i =1; i< number;i++){
      if(lista[i].GetPop()>lista[maior_pop].GetPop()){
        maior_pop = i;
      }
      if(lista[i].GetArea()>lista[maior_area].GetArea()){
        maior_area= i;
      }
    }
    Console.WriteLine("Resultados");
    Console.WriteLine($"Mais populoso: {lista[maior_pop]} - {lista[maior_pop].GetPop()} habitantes");
    Console.WriteLine($"Maior área: {lista[maior_area]} - {lista[maior_area].GetArea()} km²");
  }
}
class Pais{
  private string nome;
  private int pop;
  private int area;
  public Pais(string nome, int pop, int area){
    this.nome = nome; 
    this.pop = pop;
    this.area = area;
  }
  public int GetPop(){
    return pop;
  }
  public int GetArea(){
    return area;
  }

  public override string ToString(){
    return nome;
  }
}