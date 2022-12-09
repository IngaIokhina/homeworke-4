/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);


        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("You didn't enter a number. Enter the number");
        }
    }

    return result;
}


double GetDegree (int A, int B)
{
    return Math.Pow(A,B);
}

int A = GetNumber("Enter A");
int B = GetNumber("Enter B");

double num = GetDegree (A, B);

Console.WriteLine (num);