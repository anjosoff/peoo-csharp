using System;
class Program {
  public static void Main (){
    Carrinho compras= new Carrinho();
    bool la = true;
    while(la){
      Console.WriteLine("Digite a descricao do produto:");
      string descricao = Console.ReadLine();
      Console.WriteLine("Digite o quantidade do produto:");
      int qtd = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor do produto:");
      double preco = double.Parse(Console.ReadLine());
      if(qtd==0 && preco==0 && descricao=="0"){
        break;
      }
      Console.WriteLine("Se desejar encerrar digite 0 a partir de agora...");
      Produto novo = new Produto(descricao, qtd, preco);
      compras.Inserir(novo);

    }

    foreach(Produto i in compras.Listar()){
      Console.WriteLine(i);
    }
    Console.WriteLine($"O total foi de {compras.Somar()}");
  }
}
class Carrinho{
  private Produto[] produs = new Produto[50];
  int index=0;

  public void Inserir(Produto p){
    if(index<50){
      produs[index] = p;
      index++;
    }
  }
  public Produto[] Listar(){
    Produto[] aux_produs = new Produto[index];
    Array.Copy(produs, aux_produs, index);
    return aux_produs;
  }
  public double Somar(){
    double final=0;
    for(int i =0; i<index; i++){
      final += produs[i].GetPreco() * produs[i].GetQtd();
    }
    return final;
  }
}
class Produto{
  private string descricao;
  private int qtd;
  private double preco;
  public Produto(string descricao, int qtd, double preco){
    this.descricao = descricao;
    this.qtd = qtd;
    this.preco = preco;
  }
  public int GetQtd(){
    return qtd;
  }
  public double GetPreco(){
    return preco;
  }
  public override string ToString(){
    return$"desc  preço   quantidade\n{descricao}   {preco}   {qtd}";
  }
}