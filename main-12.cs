using System;
using System.Linq;
class Program {
  const int MinTemp = -30;
  const int MaxTemp = 130;
  //double Sum = 0;
  public static void Main (string[] args) {

    int[] tempperatures = new int[5];
    for (int i = 0; i<5; i++){
      while(true){
        Console.WriteLine($"Please enter temperature {i+1}: ");
        if(int.TryParse(Console.ReadLine(), out int temp) && MinTemp <= temp && temp <= MaxTemp){
          tempperatures[i] = temp;
          break;
        }
        else{
          Console.WriteLine("temperature must be between -30 and 130 degrees farenheight.");
        }
      }
    }

    bool warmer = false;
    bool cooler = false;
    bool MixedBag = false;
    for (int i =1; i < tempperatures.Length; i++){
      if (tempperatures[i] < tempperatures[i-1]){
        cooler = true;
      }
      else if (tempperatures[i] > tempperatures[i-1]){
        warmer = true;
      } 
       if((tempperatures[i] > tempperatures[i-1] && tempperatures[i] > tempperatures[i-1]) || (tempperatures[i] < tempperatures[i-1] && tempperatures[i] < tempperatures[i-1])){
        MixedBag = true;
      }
    }
    if (warmer){
      Console.WriteLine($"getting warmer: {string.Join(" ",tempperatures)}");
    }
    else if (cooler){
      Console.WriteLine($"getting colder: {string.Join(" ", tempperatures)}");
    }
    else if(MixedBag){
      Console.WriteLine($"Its a mixed Bag: {string.Join(" ",tempperatures)}");
    }

    double average = (double) tempperatures.Sum()/tempperatures.Length;
    Console.WriteLine($"Average: " +average);
  
  }
}