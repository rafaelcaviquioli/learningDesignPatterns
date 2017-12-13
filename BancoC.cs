namespace Pattern.Chain
{
    public class BancoC : ChainResponsability
    {
        public BancoC() : base(IDBancos.bancoC)
        {
        }

        protected override void Dispatch()
        {
            System.Console.WriteLine("Pagamento efetuado no banco C");
        }
    }
}