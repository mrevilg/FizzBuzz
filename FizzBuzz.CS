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
