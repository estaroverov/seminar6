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
double [] EquationParams(int numberOfEquation=1)
{
    int countParams = 2;
    double[] equation = new double[countParams];
    Console.Write($"Введите k{numberOfEquation}: ");
    equation[0] = double.Parse(Console.ReadLine());
    Console.Write($"Введите b{numberOfEquation}: ");
    equation[1] = double.Parse(Console.ReadLine());
    return equation;
}

void FindIntersectDot(double[] equation1, double[] equation2)
{
    double x = -(equation1[1]-equation2[1])/(equation1[0] - equation2[0]);
    double y = equation2[0]*x + equation2[1];
    Console.WriteLine($"Точка пересечения для уравнений y={equation1[0]}x+{equation1[1]};"+
    $"y={equation2[0]}x+{equation2[1]}: ({x};{y})");
}

double[] equation1 = EquationParams();
double[] equation2 = EquationParams(2);
FindIntersectDot(equation1,equation2);