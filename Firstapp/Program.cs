internal class Program
{
    private static void Main(string[] args)
    {
        //byte number = 254;
        //long number1 = Convert.ToInt64(number);
        //Console.WriteLine(number1);

        //Console.WriteLine("Законодательство США допускало отправку детей по почте до 1913 года");
        //Console.WriteLine("Ответь на данный факт true или false");
        //string answer = Console.ReadLine();
        //bool result = Convert.ToBoolean(answer);
        //Console.WriteLine($"Ответ: {result}");

        //string some = "?";
        //char mark = char.Parse(some);
        //Console.WriteLine(mark);

        //string variable = "5,25";
        //double number = double.Parse(variable);
        //Console.WriteLine(number);

        //int mult = 45*78;
        //Console.WriteLine(mult);

        //Console.WriteLine("Введите числа в диапазоне от 1 до 100.");
        //double num1 = double.Parse(Console.ReadLine());
        //double num2 = double.Parse(Console.ReadLine());
        //Console.WriteLine($"1 число: {num1}");
        //Console.WriteLine($"2 число: {num2}");
        //double result = num1/num2;
        //Console.WriteLine(result);

        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //double c = double.Parse(Console.ReadLine());
        //double d = double.Parse(Console.ReadLine());
        //double result = (b+d)/a+c;
        //Console.WriteLine(result);

        //Console.WriteLine("Введите любое число от 1 до 10:");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("Измененное число:"+ ++num);

        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine(--a*b);

        //Console.WriteLine("Введите число 1:");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите число 2:");
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine($"{a} меньше или равно {b} - {a<=b}");

        Random rand = new Random();
        double a = rand.Next(31);
        double b = rand.Next(31);
        Console.WriteLine(a+b);

    }
}