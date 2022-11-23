//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*int NumberToPower(int a, int b)
{
    int result = 1;
    for(int current = 1; current <= b; current++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine("Input number A: ");
int user_numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int user_numB = Convert.ToInt32(Console.ReadLine());

if(user_numB >= 0)
{
    int res = NumberToPower(user_numA, user_numB);
    Console.WriteLine($"Number {user_numA} to the power {user_numB} is {res}.");
}
else
    Console.WriteLine("Input positive power of number!");
*/


//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int SummaNum(int number)
{
    int summa = 0;
    while(number > 0)
    {
        summa = summa + number % 10;
        number = number / 10;
    }
    return summa;
}

Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int result;
int user_num1 = user_num * (-1);
if(user_num >= 0)
{
    result = SummaNum(user_num);
}
else result = SummaNum(user_num1);

Console.WriteLine($"{user_num} -> {result}");
*/


//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int [] NewArray(int size, int min, int max)
{
    int [] array = new int [size]; 
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1); 
    }
    return array;
}

void ShowNewArray(int []array)
{
     for(int j = 0; j < array.Length; j++)
    {
       Console.Write(array[j] + " ");
    }
}

Console.Write("Input min value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = NewArray(8, minValue, maxValue);
ShowNewArray(newArray);
*/


