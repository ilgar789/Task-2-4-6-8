            Console.WriteLine("Введите три числа:");

            // Чтение входных данных
            Console.Write("Первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Третье число: ");
            int num3 = int.Parse(Console.ReadLine());

            // Определение максимального числа
            int max = Math.Max(num1, Math.Max(num2, num3));

            // Вывод результата
            Console.WriteLine($"Максимальное число: {max}");