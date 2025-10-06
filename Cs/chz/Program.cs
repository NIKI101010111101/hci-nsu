namespace chz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task_1
            //Random random = new Random();

            //int[] array = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(0, 101); 
            //}

            //Console.WriteLine("Исходный массив:");
            //Console.WriteLine(string.Join(", ", array));

            //int minElement = array.Min();
            //int maxElement = array.Max();
            //int sumElements = array.Sum();
            //double average = array.Average();

            //Console.WriteLine("\nРезультаты:");
            //Console.WriteLine($"Минимальный элемент: {minElement}");
            //Console.WriteLine($"Максимальный элемент: {maxElement}");
            //Console.WriteLine($"Сумма всех элементов: {sumElements}");
            //Console.WriteLine($"Среднее арифметическое: {average:F2}");

            //int[] arraySorted = array.OrderBy(x => x).ToArray();

            //Console.WriteLine("\nОтсортированный массив (по возрастанию):");
            //Console.WriteLine(string.Join(", ", arraySorted));


            //task_2
            //Console.Write("Введите координату x: ");
            //double x = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите координату y: ");
            //double y = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите радиус круга: ");
            //double radius = Convert.ToDouble(Console.ReadLine());

            //double distanceSquared = x * x + y * y;
            //double radiusSquared = radius * radius;

            //bool isInsideOrOnCircle = distanceSquared <= radiusSquared;

            //if (isInsideOrOnCircle)
            //{
            //    Console.WriteLine($"Точка ({x}, {y}) принадлежит кругу с радиусом {radius}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Точка ({x}, {y}) не принадлежит кругу с радиусом {radius}.");
            //}

            //task_3
            //Console.Write("Введите высоту треугольника: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int height) && height > 0)
            //{
            //    PrintIsoscelesTriangle(height);
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка: введите положительное целое число.");
            //}

            //Console.ReadKey();
        }

        static void PrintIsoscelesTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                int spaces = height - i;
                int stars = 2 * i - 1;
                Console.WriteLine(new string(' ', spaces) + new string('*', stars));
            }
        }
    }
}
