/*
Задайте одномерный массив, заполненный случайными числами. Найдите 
сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
int[] array = GenerateArray(4, -5, 10);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
    sum = sum + array[i];
    }
}
System.Console.WriteLine(sum);
PrintArray(array);
System.Console.WriteLine();

