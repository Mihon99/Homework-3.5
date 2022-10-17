Console.WriteLine("Введите величину массива");
int n = int.Parse(Console.ReadLine());
int count = 0;
int[] array = new int[n];

int[] CreatArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    int number = new Random().Next(100, 1000);
    array[i] = number;
}
return array;
}

CreatArray(array);
string s = String.Join(", ", array);
Console.WriteLine("Изначальный массив = [" + s + "]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine("Количество четных чисел = "  + count);