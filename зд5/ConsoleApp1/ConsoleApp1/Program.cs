using ConsoleApp1;

class Program
{
    static public void Main(string[] args)
    {
        Newspaper pap1 = new Newspaper("Заря",10,30);

        pap1.Inf();
        pap1.ChangeNumber(11);
        pap1.ChangeName("New Yourk");
    }
}
