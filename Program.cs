using System;

namespace Pattern.Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            var chainResponsability = new BancoA();
            chainResponsability.SetNext(new BancoB());
            chainResponsability.SetNext(new BancoC());
            chainResponsability.SetNext(new BancoD());

            try
            {
                chainResponsability.Start(IDBancos.bancoC);
                chainResponsability.Start(IDBancos.bancoD);
                chainResponsability.Start(IDBancos.bancoA);
                chainResponsability.Start(IDBancos.bancoB);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
    }
}