
namespace _2ITA_Proc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zvire kocka = new Zvire("Kocour v botách", "kočka", 15);
            Console.WriteLine(kocka.Jmeno);
            kocka.Nakrmit(300, "maso");
            Console.WriteLine(kocka.ToString());
            Console.ReadLine();
        }
    }
}