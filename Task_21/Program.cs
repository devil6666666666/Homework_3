// Найти расстояние между двумя точками в 3D-пространстве
// по заданным координатам этих точек

Console.WriteLine("Введите координату х точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату х точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());
double Distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine($"Расстояние равно {Math.Round(Distance, 2, MidpointRounding.AwayFromZero)}");
