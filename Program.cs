// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Веедите число: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Веедите степень: ");
int B = int.Parse(Console.ReadLine()!);

int degreeCount(int A, int B)
{
    int result = 1; 
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine(degreeCount(A, B));