string basePath = @"C:\Users\needasha\source\repos\11.1\TextFile";
string path = "11.1.txt";
using (StreamWriter sw = new StreamWriter(Path.Combine(basePath, path)))
{
    sw.WriteLine("x \t\tsin(x)");
    for (double x = 0; x <= 1; x += 0.1)
    {
        sw.WriteLine($"{Math.Round(x, 1)}\t\t{Math.Round(Math.Sin(x), 4)}");
    }
}
