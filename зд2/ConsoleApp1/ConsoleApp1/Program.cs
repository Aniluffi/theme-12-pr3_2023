using ConsoleApp1;

class Program
{
    static public void Main(string[] args)
    {
        //обьект1
        HowMin time1 = new HowMin();
        time1.Inf();
        time1.HowMinets();
        time1.HowSecond();
        //обьект2
        HowMin time2 = new HowMin();

        time2.hour = 4;
        time2.min = 60;
        time2.second = 78;

        time2.Inf();
        time2.HowMinets();
        time2.HowSecond();
        //обьект3
        HowMin time3 = new HowMin(5,23,7);

        time3.Inf();
        time3.HowMinets();
        time3.HowSecond();
    }
}
