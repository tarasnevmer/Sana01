Console.Write("Input double n: ");
double n = double.Parse(Console.ReadLine());
Console.Write("Input double m: ");
double m = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / (m);
Console.WriteLine($"Result: z1 = {z1}; z2 = {z2}");


