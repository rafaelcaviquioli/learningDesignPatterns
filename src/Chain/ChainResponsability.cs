using System;

namespace Pattern.Chain
{
    public abstract class ChainResponsability : IChainResponsibility
    {
        protected ChainResponsability NextChain;
        protected Enum Identification;

        public ChainResponsability(Enum id)
        {
            NextChain = null;
            Identification = id;
        }

        public void SetNext(ChainResponsability chain)
        {
            if (NextChain == null)
            {
                NextChain = chain;
            }
            else
            {
                NextChain.SetNext(chain);
            }
        }
        public void Start(Enum id)
        {
            if (CanDispatch(id))
            {
                Dispatch();
            }
            else
            {
                if (NextChain == null)
                {
                    throw new Exception("No targets found in the chair.");
                }
                NextChain.Start(id);
            }
        }
        private Boolean CanDispatch(Enum id) => Identification.Equals(id);

        protected abstract void Dispatch();
    }
}