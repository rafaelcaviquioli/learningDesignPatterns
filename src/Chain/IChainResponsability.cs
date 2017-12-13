

using System;

namespace Pattern.Chain
{
    public interface IChainResponsibility
    {
        void SetNext(ChainResponsability chain);

        void Start(Enum id);

        Boolean CanDispatch(Enum id);

        void Dispatch();
    }
}