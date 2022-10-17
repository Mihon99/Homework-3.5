Console.WriteLine("Введите величину массива");
int n = int.Parse(Console.ReadLine());
int count = 0;
int[] array = new int[n];
int sum = 0;

int[] CreatArray(int[] array)
{
for (int i = 0; i < n; i++)
{
    int number = new Random().Next(0, 10);
    array[i] = number;
}
return array;
}

CreatArray(array);
string s = String.Join(", ", array);
Console.WriteLine("Изначальный массив = [" + s + "]");

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
    
}

Console.WriteLine("Сумма чисел на нечетных позициях в массиве = "  + sum);