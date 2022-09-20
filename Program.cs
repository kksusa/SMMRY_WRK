int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param}: ");
        if (!int.TryParse(Console.ReadLine()!, out int number) || number <= 0)
        {
            Console.WriteLine("Число введено неправильно.");
        }
        else return number;
    }
}