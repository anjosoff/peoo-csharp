using System; 

class URI {

    static void Main(string[] args) { 
      int[] x = new int[10];
      for(int i=0; i<=9;i++){
        x[i]=int.Parse(Console.ReadLine());
      }
      for(int i=0; i<=9;i++){
        if(x[i]<=0)x[i]=1;
      }
      for(int i=0; i<=9;i++){
        Console.WriteLine($"X[{i}] = {x[i]}");
      }
    }
}