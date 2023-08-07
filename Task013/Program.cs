        Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = GetThirdDigit(number);

            if (thirdDigit != -1)
            {
                Console.WriteLine($"Третья цифра числа {number}: {thirdDigit}");
            }
            else
            {
                Console.WriteLine($"Третьей цифры в числе {number} нет.");
            }
        

        static int GetThirdDigit(int num)
        {
            // Проверяем, является ли число трехзначным
            if (num >= 100 && num <= 999)
            {
                // Получаем третью цифру путем деления на 100 и взятия остатка от деления на 10
                int thirdDigit = (num / 100) % 10;
                return thirdDigit;
            }
            else
            {
                // Если число не трехзначное, возвращаем -1 как индикатор отсутствия третьей цифры
                return -1;
            }
        }