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


           // Решение без помощи класса Math
            int max2 = 0;
            int min2 = 0;
            if (a>b) {
            max2 = a ; 
            min2 = b;
            }else{ 
            max2 = b ; 
            min2 = a;
            }
            Console.WriteLine($"max = {max2}");
            Console.WriteLine($"min = {min2}");
