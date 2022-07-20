internal class Program
{
    private static void Main(string[] args)
    {
        //byte number = 254;
        //long number1 = Convert.ToInt64(number);
        //Console.WriteLine(number1);

        Console.WriteLine("Обезьяны любят бананы");
        string answer = Console.ReadLine();
        bool result = Convert.ToBoolean(answer);
        Console.WriteLine(result);
    }
}