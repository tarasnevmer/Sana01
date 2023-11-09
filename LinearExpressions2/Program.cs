Console.Write("Input double n: ");
double n = double.Parse(Console.ReadLine());
Console.Write("Input double m: ");
double m = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / (m);
Console.WriteLine($"Result: z1 = {z1}; z2 = {z2}\n");

Console.Write("Input double x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Input double a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Input double b: ");
double b = double.Parse(Console.ReadLine());

double y = 2.4f * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"Result: y = {y}");
