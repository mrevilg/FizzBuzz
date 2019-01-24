# FizzBuzz

A few approaches to the classic question in C# and Python

## C# Source Code

#1 we have a simple yet juvenile approach.
    
    ```C#
    static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 15 == 0) //I feel this is lazy coding
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        
#2 Effective but inefficient, note the duplicate call-out.
     
     static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0)) //This is more accurate to the intent, but has duplicated queries
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        
#3 True to intent and named variables.
       
       static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                var divisibleBy3 = i % 3 == 0;
                var divisibleBy5 = i % 5 == 0;

                if (divisibleBy3)
                {
                    Console.Write("Fizz");
                }

                if (divisibleBy5)
                {
                    Console.Write("Buzz");
                }

                if (!divisibleBy3 && !divisibleBy5)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
       
#4 An attempt at leveraging line spacing architecture, efficient and transparent.
    
    static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                if (i % 5 != 0 && i % 3 != 0)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
## Python Source Code

