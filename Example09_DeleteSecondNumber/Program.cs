int x = new Random().Next(100, 1000);
int nlast = x % 10;
int nsecond = x / 10 % 10;
int nfirst = x / 100 % 10;
int nrequired = nfirst * 10 + nlast;
Console.WriteLine("Введенное число: " + x);
Console.WriteLine("Полученное число: " + nrequired);
