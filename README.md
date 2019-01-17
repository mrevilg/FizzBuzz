# FizzBuzz
A few approaches to the classic question in C#


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
        
        /*  code break   */
        
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
        
       /*  code break   */
       
       
