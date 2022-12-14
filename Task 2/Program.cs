// Задайте одномерный массив, заполненый случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позиция.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int j = 1; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(1,100);
        }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
