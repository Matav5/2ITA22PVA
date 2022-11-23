namespace _2ITAProc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucitel ucitel = new Ucitel("Radim Valýn", 1000, 60, 25, 5, Role.Tank);
            Ucitel ucitel2 = new Ucitel("Lukáš Žabr", 1100, 30, 55, 1, Role.Tank);
            BOJ(ucitel, ucitel2);
        }
        public static void BOJ(Ucitel ucitel, Ucitel ucitel2)
        {
            ucitel.PripravSe();
            ucitel2.PripravSe();
            while (ucitel.JeNazivu && ucitel2.JeNazivu)
            {
                //Bude Probíhat boj
                ucitel.Utok(ucitel2);
                ucitel2.Utok(ucitel);
                Console.WriteLine("--------------------------");
            }
            if (ucitel.JeNazivu)
            {
                Console.WriteLine($"{ucitel.name} vyhrál zápas. Učitel {ucitel2.name} má zkažený život");
            }
            else {
                Console.WriteLine($"{ucitel2.name} vyhrál zápas. Učitel {ucitel.name} má zkažený život");
            }
        }
    }
}