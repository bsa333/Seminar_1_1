namespace vtornik_evening
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = new Random() .Next(10,100);
            int x1 = x/10;
            int x2 = x%10;
            Console.WriteLine($"Сгенирировано случайное число {x}");
            if (x1>x2) Console.WriteLine("Первая цифра больше");
            else if (x2>x1) Console.WriteLine("Вторая цифра больше");
            else Console.WriteLine("Это паллиндром!");
        }
        