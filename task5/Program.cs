/*Заполнить массив четной длины таким образом, чтобы значение элемента
 массива повторялось ровно 2 раза.
1,1,2,3,3,2,4,5,4,5
или
1,1,2,2,4,4,5,5
или
1,2,3,3,2,1 */
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
int[] array = GenerateArray(4, 1, 10);
PrintArray(array);
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write((array[i]) + "\t");
    System.Console.Write((array[i]) + "\t");
}
System.Console.WriteLine();