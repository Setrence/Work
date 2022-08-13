Console.Write("Введите количество строк ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
int stringCounter = 0;

for (int i = 0; i < size; i++)
{
    Console.Write("Введите строку: ");
    string stringInput = Console.ReadLine();

    if (stringInput.Length <=3)
    {
        array[stringCounter] = stringInput;
        stringCounter++;
    }
}


Console.Write($"Ответ: [");
OutputArray(array);
Console.Write("]");


void OutputArray(string[] array)
{
    for (int i = 0; i < stringCounter; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (stringCounter-1))
        {
            Console.Write($", ");
        }
    }
}
