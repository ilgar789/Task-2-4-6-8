        Console.Write("Введите цифру дня недели (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            bool isWeekend = CheckWeekend(dayNumber);

            if (isWeekend)
            {
                Console.WriteLine("Этот день является выходным.");
            }
            else
            {
                Console.WriteLine("Этот день не является выходным.");
            }
    

        static bool CheckWeekend(int dayNumber)
        {
            // Проверяем, является ли день выходным (суббота или воскресенье)
            if (dayNumber == 6 || dayNumber == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }