namespace _2ITAProc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Zak lubos = new Zak(69, "Luboš", "František", 35, 3, 2500+100);
            lubos.GOGYM(12);
            lubos.UCSE(24,2700);
            Ucitel kamil = new Ucitel(15616, "Kamil", "Balín", 106.250, 11, short.MinValue);
            kamil.GOGYM(12);
            kamil.UC(4, lubos);
            Console.ReadLine();
        }
    }
}