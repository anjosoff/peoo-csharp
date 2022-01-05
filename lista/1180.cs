using System; 

class URI {

    static void Main(string[] args) { 
      int n = int.Parse(Console.ReadLine());
      string[] aux = Console.ReadLine().Split(' ');
        int[] v = new int[n];
        for(int i = 0;i<n;i++){
          v[i] =  int.Parse(aux[i]);
        }
        int menor = v[0];
        int posicao = 0;
        for(int i = 0;i<n;i++){
          if(v[i]<menor){
              menor = v[i];
              posicao=i;
          }
        } 
        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Posicao: " + posicao);
  }
}
