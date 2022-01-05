using System; 

class URI {

    static void Main(string[] args) { 
      int[] N = new int[10];
      int v;
      v=int.Parse(Console.ReadLine());
      if(v<=50){
        for(int i=0;i<10;i++){
          N[i]=v;
          Console.WriteLine($"N[{i}] = {v}");
          v=v*2;
        }
      }
    }
}