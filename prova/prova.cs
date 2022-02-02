using System;

class MainClass{
  public static void Main(string[] args){
    int number = int.Parse(Console.ReadLine());
    Musica m = new Musica();
    Playlist play= new Playlist();
    TimeSpan duracao = new TimeSpan();
    Console.Write("Informe o número de musicas que serão adicionadas: ");
    int num = int.Parse(Console.ReadLine());
    Musica[] lista = new Musica[num];
    for(int i = 0; i< num;i++){
      Console.Write($"Informe o nome da {i+1}° musica: ");
      string titulo = Console.ReadLine();
      Console.Write($"Informe a nome do artista: ");
      int artista = int.Parse(Console.ReadLine());
      Console.Write($"Informe a duração da musica: ");
      duracao=TimeSpan.Parse(Console.ReadLine());
      Musica novo = new Musica(titulo, artista, duracao);
      //lista[i] = novo;
      play.Inserir(novo);
    }
    foreach(Produto i in play.Listar()){
      Console.WriteLine(i);
    }
  }
}

/*

bool flag = true;
    while(flag){
      Console.WriteLine("Digite o nome da musica:");
      string titulo = Console.ReadLine();
      Console.WriteLine("Digite o nome do artista":);
      int artista =Console.ReadLine();
      Console.WriteLine("Digite o a duracao da musica:");
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



*/
class Playlist{
 private  string nome;
 private  int qtd;
 private  string Musica[] musicas = new  Musica [qtd];
 int index=0;
 public void Inserir(string m){
  if(index<qtd){
    musicas[index]=m;
    index++;
  }
}

//public string Playlist(string n){
  
//}
public Musica[] Listar(){
  Musica[] aux_musica = new Musica[index];
    Array.Copy(musicas, aux_musica, index);
    return aux_musica;
}

/*

public double Somar(){
    double final=0;
    for(int i =0; i<index; i++){
      final += produs[i].GetPreco() * produs[i].GetQtd();
    }
    return final;
  }


private Produto[] produs = new Produto[50];
  int index=0;

  public void Inserir(Produto p){
    if(index<50){
      produs[index] = p;
      index++;
    }





}*/

}
class Musica{
  private string titulo;
  private string artista;
  TimeSpan duracao = new TimeSpan;
  public string Musica(string t, string a, TimeSpan d) {
    this.titulo=t;
    this.artista=a;
    this.duracao=d;
  }
  public string GetTitulo(){
    return titulo;
  }
  public string GetArtista(){
    return artista;
  }
  public TimeSpan GetDuracao(){
    return duracao;
  }
}
