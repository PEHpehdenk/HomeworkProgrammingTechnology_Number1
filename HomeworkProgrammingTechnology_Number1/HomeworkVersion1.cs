using System;

public class HomeworkProgrammingTechnology_Number1
{
    public static void markup()
    {
        Console.Write("\n-------------------------------------------------------\n");
    }
    public static void solveQuadraticEquation(double a, double b, double c)
    {
        double discriminant;
        double answer;
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0) {
                    Console.Write("\nУравнение имеет бесконечно много решений\n");
                    return;
                }
                Console.Write("\nУравнение не имеет решений\n");
                return;
            }
            answer = -c / b;
            Console.Write("\nУравнение имеет единственное решение\n");
            Console.Write($"\nX = {answer}\n");
            return;
        }
        discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.Write("\nУравнение не имеет решений в действительных числах\n");
            return;
        }
        if (discriminant == 0)
        {
            answer = -b / (2 * a);
            Console.Write("\nУравнение имеет единственное решение\n");
            Console.Write($"\nX = {answer}\n");
            return;
        }
        double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine("\nУравнение имеет два решения\n");
        Console.WriteLine($"X1 = {x1}");
        Console.WriteLine($"X2 = {x2}");
        return;
    }
    public static void task1()
    {
        Console.Write("\nЗадача 1\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализованы две вариации вывода данных, указанных в условии задачи.");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Console.WriteLine("Вариация (a):");
        Console.WriteLine("\nМир Труд Май\n");
        Console.WriteLine("Вариация (b):");
        Console.Write("\nМир\n\tТруд\n\t\tМай\n");
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task2()
    {
        Console.Write("\nЗадача 2\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализован обмен значениями двух переменных, введенных пользователем.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask2 = false;
        while (!stopTask2)
        {
            Console.WriteLine("\nВведите два числа. Дробная часть числа должна быть разделена от целой запятой.\n");
            try
            {
                double variable1;
                double variable2;
                Console.Write("Первое число: ");
                variable1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Второе число: ");
                variable2 = Convert.ToDouble(Console.ReadLine());
                (variable1, variable2) = (variable2, variable1);
                Console.WriteLine("\nНовые значения переменных:\n");
                Console.WriteLine($"Первая переменная: {variable1}");
                Console.WriteLine($"Вторая переменная: {variable2}");
                stopTask2 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task3()
    {
        Console.Write("\nЗадача 3\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализовано нахождение длины окружности и площади круга по заданному радиусу.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask3 = false;
        while (!stopTask3)
        {
            Console.WriteLine("\nВведите радиус окружности. Дробная часть числа должна быть разделена от целой запятой.\n");
            try
            {
                double radius;
                double circumference;
                double area;
                Console.Write("Радиус: ");
                radius = Convert.ToDouble(Console.ReadLine());
                if (radius < 0)
                {
                    Console.Write("\nОШИБКА: Радиус не может быть отрицательным числом.\n");
                    continue;
                }
                circumference = 2 * Math.PI * radius;
                area = Math.PI * radius * radius;
                Console.Write($"\nДлина окружности: {circumference}\n");
                Console.WriteLine($"Площадь круга: {area}");
                stopTask3 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task4()
    {
        Console.Write("\nЗадача 4\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализовано вычисление косинуса.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask4 = false;
        while (!stopTask4)
        {
            Console.WriteLine("\nВведите число (в радианах), косинус которого вы хотите найти. Дробная часть числа должна быть разделена от целой запятой.\n");
            try
            {
                double number;
                Console.Write("Число: ");
                number = Convert.ToDouble(Console.ReadLine());
                Console.Write($"\nКосинус: {Math.Cos(number)}\n");
                stopTask4 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task5()
    {
        Console.Write("\nЗадача 5\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализовано решение квадратного уравнения.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask5 = false;
        while (!stopTask5)
        {
            Console.WriteLine("\nВведите коэффициенты квадратного уравнения (значения a, b, c из выражения ax² + bx + c). Дробная часть числа должна быть разделена от целой запятой.\n");
            try
            {
                double coefficientA;
                double coefficientB;
                double coefficientC;
                Console.Write("a: ");
                coefficientA = Convert.ToDouble(Console.ReadLine());
                Console.Write("b: ");
                coefficientB = Convert.ToDouble(Console.ReadLine());
                Console.Write("c: ");
                coefficientC = Convert.ToDouble(Console.ReadLine());
                solveQuadraticEquation(coefficientA, coefficientB, coefficientC);
                stopTask5 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task6()
    {
        Console.Write("\nЗадача 6\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализован обмен значениями трёх переменных введенных пользователем по схемам из условия.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask6 = false;
        while (!stopTask6)
        {
            Console.WriteLine("\nВведите три числа (a, b, c). Дробная часть числа должна быть разделена от целой запятой.\n");
            try
            {
                double variableA;
                double variableB;
                double variableC;
                Console.Write("a: ");
                variableA = Convert.ToDouble(Console.ReadLine());
                Console.Write("b: ");
                variableB = Convert.ToDouble(Console.ReadLine());
                Console.Write("c: ");
                variableC = Convert.ToDouble(Console.ReadLine());
                (variableB, variableA, variableC) = (variableC, variableB, variableA);
                Console.WriteLine("\nНовые значения переменных по схеме (a):\n");
                Console.WriteLine($"a: {variableA}");
                Console.WriteLine($"b: {variableB}");
                Console.WriteLine($"c: {variableC}");
                (variableC, variableB, variableA) = (variableB, variableA, variableC);
                (variableB, variableC, variableA) = (variableA, variableB, variableC);
                Console.WriteLine("\nНовые значения переменных по схеме (b):\n");
                Console.WriteLine($"a: {variableA}");
                Console.WriteLine($"b: {variableB}");
                Console.WriteLine($"c: {variableC}");
                stopTask6 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task7()
    {
        Console.Write("\nЗадача 7\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализован вывод четырех рандомных чисел в столбик.");
        Console.WriteLine("\nРЕАЛИЗАЦИЯ:\n");
        Random random = new Random();
        int number1 = random.Next();
        int number2 = random.Next();
        int number3 = random.Next();
        int number4 = random.Next();
        Console.Write("\nРезультат:\n");
        Console.Write($"\n{number1}\n{number2}\n{number3}\n{number4}\n");
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task8()
    {
        Console.Write("\nЗадача 8\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче реализована перестановка разряда единиц с разрядами сотен трехзначного числа.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask8 = false;
        while (!stopTask8)
        {
            Console.WriteLine("\nВведите трёхзначное положительное число\n");
            try
            {
                int number;
                Console.Write("Число: ");
                number = Convert.ToInt16(Console.ReadLine());
                if (!(100 <= number && number <= 999))
                {
                    Console.Write("\nОШИБКА: Введенное число не трёхзначное.\n");
                    continue;
                }
                number = number % 10 * 100 + number % 100 / 10 * 10 + number / 100;
                Console.Write("\nРезультат:\n");
                Console.Write($"\nНовое трёхзначное число: {number}\n");
                stopTask8 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }

    public static void task9()
    {
        Console.Write("\nЗадача 9\n");
        Console.WriteLine("\nОПИСАНИЕ:\n");
        Console.WriteLine("В данной задаче на вход подаётся стоимость 1 килограмма конфет, печенья и яблок соответсвенно. Программа выводит стоимость покупки состоящей из x, y, z килограммов конфет, печенья и яблок соответсвенно.");
        Console.Write("\nРЕАЛИЗАЦИЯ:\n");
        bool stopTask9 = false;
        while (!stopTask9)
        {
            Console.WriteLine("\nВведите стоимость 1 килограмма конфет, печенья и яблок. Дробная часть числа должна быть разделена от целой запятой.\n");
            try
            {
                double priceOfCandies;
                double priceOfCookies;
                double priceOfApples;
                double x;
                double y;
                double z;
                double purchaseAmount;
                Console.Write("Цена 1 килограмма конфет: ");
                priceOfCandies = Convert.ToDouble(Console.ReadLine());
                Console.Write("Цена 1 килограмма печенья: ");
                priceOfCookies = Convert.ToDouble(Console.ReadLine());
                Console.Write("Цена 1 килограмма яблок: ");
                priceOfApples = Convert.ToDouble(Console.ReadLine());
                Console.Write("Всего килограмм конфет: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Всего килограмм печенья: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Всего килограмм яблок: ");
                z = Convert.ToDouble(Console.ReadLine());
                purchaseAmount = priceOfCandies * x + priceOfCookies * y + priceOfApples * z;
                Console.Write("\nРезультат:\n");
                Console.Write($"\nСтоимость покупки: {purchaseAmount}\n");
                stopTask9 = true;
            }
            catch
            {
                Console.Write("\nОШИБКА: Введенныё данные не соответствуют требуемому формату.\n");
            }
        }
        Console.Write("\nВыполнение задачи завершено.\n");
    }
    public static void Main()
    {
        Console.WriteLine("Программа запущена успешно.");
        bool stopProgramm = false;
        while (!stopProgramm)
        {
            Console.WriteLine("\nВведите номер задачи (от 1 до 9), чтобы завершить просмотр задач введите 0\n");
            Console.Write("Номер задачи: ");
            try
            {
                int number_of_task = Convert.ToInt32(Console.ReadLine());
                switch (number_of_task)
                {
                    case 0:
                        stopProgramm = true;
                        continue;
                    case 1:
                        markup();
                        task1();
                        markup();
                        continue;
                    case 2:
                        markup();
                        task2();
                        markup();
                        continue;
                    case 3:
                        markup();
                        task3();
                        markup();
                        continue;
                    case 4:
                        markup();
                        task4();
                        markup();
                        continue;
                    case 5:
                        markup();
                        task5();
                        markup();
                        continue;
                    case 6:
                        markup();
                        task6();
                        markup();
                        continue;
                    case 7:
                        markup();
                        task7();
                        markup();
                        continue;
                    case 8:
                        markup();
                        task8();
                        markup();
                        continue;
                    case 9:
                        markup();
                        task9();
                        markup();
                        continue;
                    default:
                        Console.WriteLine("\nОШИБКА: Введённые данные не принадлежат требуемому диапазону (от 0 до 9 включительно).\n");
                        continue;
                }
            }
            catch
            {
                markup();
                Console.Write("\nОШИБКА: Введённые данные не являются числом.\n");
                markup();
            }
        }
    }
}
