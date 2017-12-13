namespace Pattern.Chain
{
    public class BancoB : ChainResponsability
    {
        public BancoB() : base(IDBancos.bancoB)
        {
        }

        protected override void Dispatch()
        {
            System.Console.WriteLine("Pagamento efetuado no banco B");
        }
    }
}