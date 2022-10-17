Console.WriteLine("Введите размер массива ");
int b = Convert.ToInt32(Console.ReadLine());
double [] array  = new double [b];

void FillArrayRandomNumbers (double [] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(1,100)) / 10;
        }
}

FillArrayRandomNumbers(array);
string s = String.Join(", ", array);
Console.WriteLine("Изначальный массив = [" + s + "]");

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array [i] > max)
        {
            max = array[i];
        }
    if (array [i] < min)
        {
            min = array[i];
        }
}

double result = max - min; 

Console.WriteLine("Максимум массива = " + max);
Console.WriteLine("Минимум массива = " + min);
Console.WriteLine("Разница между максимумом и минимумом = " + result);

