
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.WriteLine("Введите число 1: ");
        Console.WriteLine("Введите число 2: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Первое число большее");
        }
        else 
        {
            Console.WriteLine("Второе число большее");
        }
        if (num1 < num2)
        {
            Console.WriteLine("Первое число меньшее");
        }
        else 
        {
            Console.WriteLine("Второе число меньшее");
        }