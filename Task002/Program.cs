            // Чтение входных данных
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            // Определение максимального и минимального чисел
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            // Вывод результатов
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
