// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int lenArray = ReadInt("Введите длинну массива: ");
int leftBorder = ReadInt("Ведите левую границу начала массива: ");
int rightBorder = ReadInt("Введите правую границу окончания массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(leftBorder, rightBorder + 1);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}