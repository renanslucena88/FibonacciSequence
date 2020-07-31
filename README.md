# FibonacciSequence

Hi everybody

This simple solution is only to show a Fibonacci Sequence in C#.

To understand the Fibonacci Sequence, you must imagine the numbers increasing as a spiral.



N = Fibonacci N-1 + Fibonacci N-2


F(0)=	0

F(1)=	1  

F(2)=	1     

F(3)=	2  =>  1+1

F(4)=	3  =>  2+1

F(5)=	5  =>  3+2

F(6)=	8  =>  5+3

F(7)=	13 =>  8+5

F(8)=	21 =>  13+8

F(9)=	34 =>  21+13

F(10)= 55 => 34+21


 ![alt text](https://cdn.pixabay.com/photo/2015/12/06/17/55/fibonacci-1079783_960_720.jpg)
 
 
There are many ways to find out Fibonacci from any number and the most popular way to solve this problem is using a recursive method, as in the example below:
```
  public static int GetFibonacciRecursive(int n)
  {
        if (n == 2 || n == 1)
        {
            return 1;
        }
        else
        {
            return GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
        }
    }
 ```
  
 
The performance of the example above is terrible !!!! PLEASE FORGET IT!!! If you are in the hiring process and the interviewer asks to create or gives to you a Fibonacci test, use one of the examples below to solve with the better performance.



If the interviewer really wants that you create a recursive function....follow the example
 
 
 ```
  public static double Fibonacci2(int n)
  {
      if (n <= 1)
      {
          return n;
      }

      double[] fibo = new double[n + 1];
      return Fibonacci2(fibo, n);
  }
  public static double Fibonacci2(double[] fibo, int n)
  {
      if (n <= 1)
      {
        return n;
      }

      if (fibo[n] > 0)
      {
          return fibo[n];
      }
      
      double result = Fibonacci2(fibo, n - 1) + Fibonacci2(fibo, n - 2);

      fibo[n] = result;

      return result;
  }
 ```
  
 
 NOW if you want better performance, USE THE EXAMPLE BELOW
 
 ```
  public static BigInteger GetFibonacci(int n)
  {
      int a = 1;
      if (n == 1 || n == 2)
      {
          return 1;
      }

      BigInteger result = 0;
      BigInteger previous1 = 0;
      BigInteger previous2 = 1;

      while (a <= n)
      {
          if (a == 1 || a == 2)
          {
              previous1 = 1;
              previous2 = 1;
          }
          else
          {
              var temp = previous1;
              result = previous1 + previous2;
              previous2 = temp;
              previous1 = result;
          }
          a++;
      }
      return result;
  }
       
       
  ```
 
 
 
 
 For any question, please let me know!!!
