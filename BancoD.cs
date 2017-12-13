namespace Pattern.Chain
{
    public class BancoD : ChainResponsability
    {
        public BancoD() : base(IDBancos.bancoD)
        {
        }

        protected override void Dispatch()
        {
            System.Console.WriteLine("Pagamento efetuado no banco D");
        }
    }
}