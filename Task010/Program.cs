        Console.Write("Введите трёхзначное число: ");

            int number = int.Parse(Console.ReadLine());
            int secondDigit = GetSecondDigit(number);

            Console.WriteLine($"Вторая цифра числа {number} : {secondDigit}");

        static int GetSecondDigit(int num)
        {
            // Получаем вторую цифру путем деления на 10 и взятия остатка от деления на 10
            int secondDigit = (num / 10) % 10;
            return secondDigit;
        }