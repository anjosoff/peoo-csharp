using System;

class Program {
  public static void Main (string[] args) {
    pagamento a = new pagamento ();
    a.SetValor(400);
    a.SetNumParcelas(4);
    Console.WriteLine($"O valor a vista com 10% de desconto é: {a.GetValorAvista()}");
    Console.WriteLine($"O valor de cada parcela é:{a.GetValorParcela()}");
  }
}
class pagamento{
  private double valor;
  private int numParcelas;
  public void SetValor(double a) { 
    valor = a;
  }
  
  public void SetNumParcelas(int b) { 
    numParcelas = b;
  }

  public double GetValorParcela(){
    double parcela; 
    parcela= valor/numParcelas;
    return parcela;
  }
  public double GetValorAvista(){
    double avista; 
    avista = valor * 0.9;
    return avista;
  }
}