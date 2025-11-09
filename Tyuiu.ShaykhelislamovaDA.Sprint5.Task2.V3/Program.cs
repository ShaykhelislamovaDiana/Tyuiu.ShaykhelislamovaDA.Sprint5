using Tyuiu.ShaykhelislamovaDA.Sprint5.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Двумерные массивы  (статический ввод)                                   *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 6. Найдите сумму нечетных   *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] mat = new int[3, 3]; 
        for (int i = 0; i < 3;  i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Введите значение элемента (" + (i+1) + "," + (j+1) + "):");
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Задана матрица:");
        for (int i = 0;i < 3; i++)
        {
            for(int j = 0;j < 3; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.SaveToFileTextData(mat));

    }
}