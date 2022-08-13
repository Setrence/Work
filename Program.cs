Console.Write("Введите количество строк ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
int b = 0;

for (int i = 0; i < size; i++)
{
    Console.Write("Введите строку: ");
    string a = Console.ReadLine();

    if (a.Length <=3)
    {
        array[b] = a;
        b++;
    }
}


Console.Write($"Ответ: [");
OutputArray(array);
Console.Write("]");


void OutputArray(string[] array)
{
    for (int i = 0; i < b; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (b-1))
        {
            Console.Write($", ");
        }
    }
}
