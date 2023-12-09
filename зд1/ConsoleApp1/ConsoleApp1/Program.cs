using ConsoleApp1;

class Program
{
    static public void Main(string[] args)
    {
        //обьект1
        ActionsNumber num1 = new ActionsNumber();
        num1.Inf();
        num1.Sqrt();

        //обьект2
        ActionsNumber num2 = new ActionsNumber();
        num2.num1 = 2;
        num2.num2 = 2;

        num2.Inf();
        num2.Sqrt();

        //обьект 3
        Console.WriteLine("Число1");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Число2");
        double y = Convert.ToDouble(Console.ReadLine());

        ActionsNumber num3 = new ActionsNumber(x,y);

        num3.Inf();
        num3.Sqrt();
    }
}
