string[] array = {"Hello","23","Hi","Fish"};
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i].Length <3)
//     {
//         int count = 0;
//         count++;
//         string[] LessThreeSymbols = new string[count];
        
//         LessThreeSymbols[count] = array[i];
        
//     }
// }
static int Counter(string[] array)
{
    
    int count = new int();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 3)
        {
            count++;
        }
    }
    return count;
}
