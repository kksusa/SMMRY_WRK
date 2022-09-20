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

string[] InputArray(string[] array)  
{    
    Console.WriteLine(); 
    for (int i = 0; i < array.Length; i++)  
    {  
        Console.Write($"Введите {i + 1}-й элемент массива: ");  
        array[i] = Console.ReadLine()!;  
    }  
    return array;
} 

void PrintArray(string[] array)  
{  
    Console.Write("[");  
    for (var i = 0; i < array.Length; i++)  
    {  
        Console.Write(array[i]);  
        if (i != array.Length - 1) Console.Write(", ");  
    }
    Console.Write("]");
    Console.WriteLine();
}  