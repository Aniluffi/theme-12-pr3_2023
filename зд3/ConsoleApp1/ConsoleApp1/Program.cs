using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"сторона1");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"сторона2");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"основание");
        double fon = Convert.ToDouble(Console.ReadLine());

        Tringle tr1 = new Tringle(side1,side1,fon);

        tr1.Inf();
        tr1.PTringle();
    }
}
