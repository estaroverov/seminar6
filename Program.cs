// Первая задача
// Функция подсчета в ряде чисел положительных чисел
void CountPositiveNumbers(int quantity)
{
    int counter = 0;
    int number;
    for (int i = 0; i < quantity; i++)
    {
        number = int.Parse(Console.ReadLine());
        if (number > 0)
            counter++;
    }
    Console.WriteLine($"Всего положительных чисел: {counter}");
}
CountPositiveNumbers(5);

// Вторая задача
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Функция задания точек координат прямых
double[] EquationParams(int numberOfEquation = 1)
{
    int countParams = 2;
    double[] equation = new double[countParams];
    Console.Write($"Введите k{numberOfEquation}: ");
    equation[0] = double.Parse(Console.ReadLine());
    Console.Write($"Введите b{numberOfEquation}: ");
    equation[1] = double.Parse(Console.ReadLine());
    return equation;
}
// 
void FindIntersectDot(double[] equation1, double[] equation2)
{
    double x, y;
    // Вычитаем из первого уравнения второе и переносим значение b1-b2 по другую сторону от знака равенства:
    if (equation1[0] - equation2[0] != 0)
    {
        x = -(equation1[1] - equation2[1]) / (equation1[0] - equation2[0]);
        //Подставляем значения x во второе уравнение и находим y:
        y = equation2[0] * x + equation2[1];
        Console.WriteLine($"Точка пересечения для уравнений y={equation1[0]}x+{equation1[1]};" +
            $"y={equation2[0]}x+{equation2[1]}: ({x};{y})");
    }
    else if (equation1[1] == equation2[1])
        Console.WriteLine("Прямые равны.Деление на 0");
    else
        Console.WriteLine("Прямые не пересекаются");

}

double[] equation1 = EquationParams();
double[] equation2 = EquationParams(2);
FindIntersectDot(equation1, equation2);


// Первая дополнительная задача, вычислить стпень числа с помощью рекурсивной функции:
int power(int number, int p)
{

    if (p > 0)
        return number * power(number, p - 1);
    else if (p == 0)
        return 1;
    else
    {
        Console.Write("Неположительная степень ");
        return p;
    }
}
Console.WriteLine(power(5, 0));

//Вторая дополнительная задача - распечатать квадратную матрицу в определенном порядке
int[,] FillMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)

        for (int j = 0; j < n; j++)
            if (j >= i)
                matrix[i, j] = i + 1;
            else
                matrix[i, j] = j + 1;
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}
PrintMatrix(FillMatrix(7));
