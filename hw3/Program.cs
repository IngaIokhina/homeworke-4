/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetMassiv ()
{
    int[] massiv = new int[8];
    Random rnd = new Random(); 
    for (int i = 0; i < massiv.Length; i++)
    {
        
        massiv[i] = rnd.Next(0, 100); // int.MaxValue - если указать вот это, 
        //то это вообще любые числа, но они получаются очень большие

    }

    return massiv;
}

int[] array = GetMassiv();

Console.Write("[");
for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write($"{array[i]}, ");
    }
Console.Write("]");



