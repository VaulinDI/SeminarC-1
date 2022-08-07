int x = new Random().Next(100, 1000);
Console.WriteLine(x);
Console.WriteLine("Вторая цифра числа: " + x / 10 % 10 % 10);
