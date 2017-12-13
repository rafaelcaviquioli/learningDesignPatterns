namespace Pattern.Chain
{
    public class BancoA : ChainResponsability
    {
        public BancoA() : base(IDBancos.bancoA)
        {
        }

        protected override void Dispatch()
        {
            System.Console.WriteLine("Pagamento efetuado no banco A");
        }
    }
}