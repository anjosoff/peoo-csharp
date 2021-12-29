using System;

class Program{
  public static void Main(string[] args){
    /*
    > variaveis por valor
    struct
    enum
    > variaveis por referencia
    string
    class
    */
    string s = "Teste";
    Console.WriteLine(s.Substring(2,2));
   Aluno a;
   Professor p = new Professor();
   p.idade=50;
   a.idade=20;
   Console.WriteLine(p.idade);
  }
}
struct Aluno{
  public int idade;
}
class Professor{
  public int idade;
}