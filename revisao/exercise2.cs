using System;

class Program {
  public static void Main (){
    Console.Write("Insira o número de andares: ");
    int andares = int.Parse(Console.ReadLine());
    Console.Write("Insira o número de apartamentos por andar: ");
    int aptos= int.Parse(Console.ReadLine());   
    Apto total = new Apto();
    total.SetNumAndares(andares);
    total.SetNumAptosAndar(aptos);
    foreach(int i in total.GetNumeros()){
      Console.WriteLine($"Apartamento {i}  ");
    }
  }
}
class Apto{
  private int numAndares;
  private int numAptosAndar;
  public void SetNumAndares(int i){
    numAndares = i;
  }
  public void SetNumAptosAndar(int i){
    numAptosAndar = i;
  }
  public int[] GetNumeros(){
    int[]numeros = new int[this.numAndares*this.numAptosAndar];
    int index=0;
    for(int i =1; i<=numAndares;i++){
      for(int j =1; j<=numAptosAndar;j++){
        numeros[index]= i*100 + j;
        index++;
      }
    }
    return numeros;
  }
}