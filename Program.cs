string[] array = { "Hello", "23", "Hi", "99", "Fish" };

int count = new int();

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 3)
    {
        count++;
    }
}

string[] LessThreeSymbolsArray = new string[count];

for (int i = 0; i < array.Length; i++)
{
    int index = 0;
    if (array[i].Length < 3)
    {
        LessThreeSymbolsArray[index] = array[i];
        Console.Write(LessThreeSymbolsArray[index] + " ");
    }
}



