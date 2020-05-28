using System;

namespace FakeItEasyConcrete
{
    public class FakeClass
    {
        public virtual bool Teste()
        {
            throw new Exception();
        }
    }
}
