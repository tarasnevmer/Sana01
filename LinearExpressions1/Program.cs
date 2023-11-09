Console.Write("Input double a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Input double b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Input double c: ");
double c = double.Parse(Console.ReadLine());
Console.Write("Input double d: ");
double d = double.Parse(Console.ReadLine());

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"Result x: {x}");

double y = ((5 * (a + b) * (c - d)) / ((1.0f / 2.0f) * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
Console.WriteLine($"Result y: {y}");

double z = (((Math.Pow(Math.Pow(x, 2) - 2 * x, 3)) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) ) / (5 * a + 3 * b);
Console.WriteLine($"Result z: {z}");

double r = ((1.0f / 2.0f * a + 3.0f /4.0f  * b - 7.0f /5.0f ) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine($"Result r: {r}");
