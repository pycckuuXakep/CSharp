/******************************************************************************
*******************************************************************************/

using System;
class HelloWorld {
  static void sixth() {
        Console.WriteLine("Input: num of month - 1..12");
        Console.Write("Num of Month: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        if(N == 1 ||
           N == 2 ||
           N == 4 ||
           N == 6 ||
           N == 8 ||
           N == 9 ||
           N == 11)
            Console.WriteLine("Days: 31");
        else
            Console.WriteLine("Days: 30");
  }
    
  static void fifth() {
        Console.WriteLine("Check equals numbers in number. Number should be 10..99");
        
        Console.Write("Number: ");

        int x = Convert.ToInt32(Console.ReadLine());
        
        int s = x % 10;
        int f = x / 10;
        
        if(f != s)
            Console.WriteLine("In " + x + " number " + f + " not equal number " + s);
        else
            Console.WriteLine("It's equal");
  }
    
  static void fourth() {
        Console.WriteLine("x, y - coords is in circle with radius r ?");
      
        Console.Write("Radius: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("X coord: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y coord: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        if (x*x + y*y < r*r)
            Console.WriteLine("Is on circle");
        else
            Console.WriteLine("Is not on circle");
  }
    
  static void third() {
        Console.WriteLine("Check N % 5 != 0 and N % 2 (3) == 0");
      
        Console.Write("Number: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        if ((N % 5) != 0)
            if ((N % 3) == 0 && 
                (N % 2) == 0)
            {
                Console.WriteLine("Yes");
                return;
            }
        Console.WriteLine("No");
  }
    
  static void second() {
        Console.WriteLine("Input three numbers and check most less");
      
        Console.Write("First Number: ");
        int f = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second Number: ");
        int s = Convert.ToInt32(Console.ReadLine());
        Console.Write("Third Number: ");
        int t = Convert.ToInt32(Console.ReadLine());
        
        if(f<s && f<t)
            Console.WriteLine(f);
        else if(s<t)
            Console.WriteLine(s);
        else
            Console.WriteLine(t);
  }
    
  static void first() {
        Console.WriteLine("Evaluate math statement");
        Console.WriteLine("If sqrt(a+b) then a*x*x + b * Math.Log10(Math.Abs(2*x))");
        Console.WriteLine("else Math.Sqrt(a + Math.Sin(2*x))");
      
        Console.Write("Number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        double y = (Math.Sqrt(a+b) < x) ?
            (a*x*x + b * Math.Log10(Math.Abs(2*x)))
        :
            (Math.Sqrt(a + Math.Sin(2*x)));
        
        Console.WriteLine("y = " + y);
  }
  
  static void Main() {
        first();
        second();
        third();
        fourth();
        fifth();
        sixth();
  }
}
