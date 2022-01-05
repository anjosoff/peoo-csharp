using System; 

class URI {

    static void Main(string[] args) { 
      double[] A = new double[100];
      for(int i =0; i<=5;i++){
        A[i]=double.Parse(Console.ReadLine());
      }
      for(int i=0; i<=5;i++){
        if(A[i]<=10.0){
          Console.WriteLine($"A[{i}]"+double.Parse(A[i]));
        }
      }  
  }
}