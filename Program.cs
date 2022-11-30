Console.Write("Введите длину массива: ");  // Ввод массива с клавиатуры
int len = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[len];
int count = 0;
for (int i = 0; i < len; i++)
{
    Console.Write("Введите строку: ");
    inputArray[i] = Console.ReadLine();
    if (inputArray[i].Length <= 3) count++;  // Счетчик строк, удовлетворяющих условию (для определения длины нового массива)
}

Console.WriteLine("Исходный массив:");
PrintArray(inputArray);
string[] outputArray = ModifyArray(inputArray, count);
Console.WriteLine("Получившийся массив:");
PrintArray(outputArray);

void PrintArray(string[] array)   // Вывод массива на экран
{
    int n = array.Length;
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

string[] ModifyArray(string[] primArray, int newLength)  // Создание нового массива из имеющегося
{
    string[] resArray = new string[newLength];
    int n = 0;
    for (int i = 0; i < primArray.Length; i++)
    {
        if (primArray[i].Length <= 3)
        {
            resArray[n] = primArray[i];
            n++;
        }
    }
    return resArray;
}