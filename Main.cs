using System; 

public class Program {

  public static void Main(string[] args) {

    
    /*  2015 VCAA Exam

    int A = 3;
    int B = 5;
    int C = 0;
    while (A < 2 * B)
    {  
      int C = A*A;
      A++;
      B = B - 1;
      Console.WriteLine(C);
    }
    */

    /*   2019 VCAA Exam
    int x = 4;
    int y = 0;
    do {
      y = x + 10;
      if (x < 8)
        { 
          x++;
        }
    }
    while (y < 15);
    Console.WriteLine($"{x}, {y}");
  }*/ 

    Console.WriteLine("Enter a number for A");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number for B");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine($"A + B = {A+B}, A * B = {A*B}");
  }
}