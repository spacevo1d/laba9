using lb9;

public delegate double MyFun(double x);
class Program
{

    static double F(double x, MyFun f)
    {
        return f(x);
    }
    static double[] Zap(double[] arr, int k1, int k2)
    {
        if (k1 < 0)
        {
            throw new InvalidData("Левая граница меньше нуля!!!");
        }
        if (k2 >= arr.Length)
        {
            throw new InvalidData("правая граница больше размерности массива!!!");
        }
        if (k2 < k1)
        {
            throw new InvalidData("Правая граница меньше левой границы!!!");
        }
        for (int i = k1; i <= k2; i++)
        {
            Console.WriteLine($"Введите {i} элемент:");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        return arr;
    }
    static double[] Zaprnd(double[] arr, int k1, int k2)
    {
        if (k1 < 0)
        {
            throw new InvalidData("Левая граница меньше нуля!!!");
        }
        if (k2 >= arr.Length)
        {
            throw new InvalidData("правая граница больше размерности массива!!!");
        }
        if (k2 < k1)
        {
            throw new InvalidData("Правая граница меньше левой границы!!!");
        }
        for (int i = k1; i <= k2; i++)
        {
            Random random = new Random();
            arr[i] = random.Next(-10, 10);
        }
        return arr;
    }
    static void Prov(double[] x, double[] y)
    {
        int count = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (y[i] != double.NaN)
            {
                if (x[i] >= -4 && x[i] <= 0 && y[i] >= -4 && y[i] <= 4)
                {
                    count++;
                    Console.WriteLine($"({x[i]},{y[i]})");
                }
                else if (y[i] == -x[i] + 4)
                {
                    count++;
                    Console.WriteLine($"({x[i]},{y[i]})");
                }
            }
        }
        Console.WriteLine("Кол-во точек:" + count);
    }
    static double Dlina(double[] x, double[] y)
    {
        double dl = 0;
        for (int i = 0; i < x.Length - 1; i++)
        {
            if (y[i] != double.NaN)
            {
                dl += Math.Sqrt(Math.Pow(x[i] - x[i + 1], 2) + Math.Pow(y[i] - y[i + 1], 2));
            }
        }
        return dl;
    }
    static void Main()
    {
        MyFun f = (double x) =>
        {
            Random random = new Random();
            int a = random.Next(-50, 50);
            if (x == double.PositiveInfinity || x == double.NegativeInfinity)
            {
                throw new InvalidData("Деление на бесконечность!!!");
            }
            if (x - a == 0 || a * a - x * x == 0)
            {
                throw new InvalidData("Деление на ноль!!!");
            }
            if (a * a - x * x < 0)
            {
                throw new InvalidData("Подкорневое выражение принимает отрицательное значение!!!");
            }
            if (x < 0)
            {
                return x + Math.Pow(Math.Sin(1 / (x - a) + 4), 2);
            }
            else
            {
                return x * a / Math.Sqrt(a * a - x * x);
            }
        };
        MyFun incorrectF = (double x) =>
        {
            int a = 5;
            if (x == double.PositiveInfinity || x == double.NegativeInfinity)
            {
                throw new InvalidData("Деление на бесконечность!!!");
            }
            if (x - a == 0 || a * a - x * x == 0)
            {
                throw new InvalidData("Деление на ноль!!!");
            }
            if (a * a - x * x < 0)
            {
                throw new InvalidData("Подкорневое выражение принимает отрицательное значение!!!");
            }
            if (x < 0)
            {
                return x + Math.Pow(Math.Sin(1 / (x - a) + 4), 2);
            }
            else
            {
                return x * a / Math.Sqrt(a * a - x * x);
            }
        };
        try
        {
            //Задание 1
            //Console.WriteLine("Введите х:");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double fx = f(x);
            //Console.WriteLine(fx);

            //Задание 2
            //double[] arr = new double[5];
            //double[] arr1=new double[5];
            //Zap(arr, 0, 4);
            //Zaprnd(arr1, 1, 4);

            //Задание 3
            //int k1, k2,n;
            //Console.WriteLine("Введите размер массива:");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите k1:");
            //k1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите k2:");
            //k2 = Convert.ToInt32(Console.ReadLine());
            //double[] mas = new double[n];
            //Zaprnd(mas, 0, n-1);
            //Zap(mas,k1,k2);
            //Console.Write("x=(");
            //for (int i = 0; i < n; i++)
            //{
            //    if (i < n - 1)
            //        Console.Write(mas[i] + ",");
            //    else
            //        Console.Write(mas[i]);
            //}
            //Console.WriteLine(")");
            //double[] y = new double[n];
            //for(int i = 0; i < n; i++)
            //{
            //    y[i] = f(mas[i]);
            //}
            //Console.Write("y=(");
            //for (int i = 0; i < n; i++)
            //{
            //    if (i < n - 1)
            //        Console.Write(y[i] + ",");
            //    else
            //        Console.Write(y[i]);
            //}
            //Console.WriteLine(")");
            //Prov(mas, y);
            //Console.WriteLine("Длинa ломаной линии, соединяющей их в порядке индексации в массиве: "+Dlina(mas,y));

            //Задание 4a
            //double x1 = 5;
            //double fx1 = incorrectF(x1);
            //Console.WriteLine(fx1);
            //Задание 4b
            double[] prv1 = new double[3];
            double[] prv2 = new double[3];
            //He Ошибка 
            //Zap(prv1, 0, 3);
            Zap(prv1, 0, 2);
            //Ошибка 
            Zaprnd(prv2, -1, 2);
            //He Ошибка 
            //Zaprnd(prv2, 0, 2);
        }
        catch (InvalidData e)
        {
            Console.WriteLine("Ошибка:" + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Ошибка:" + e.Message);
        }
        finally
        {
            Console.WriteLine("Программа завершилась");
        }
    }
}
