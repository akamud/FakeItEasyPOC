namespace FakeItEasyConcrete
{
    public class Class1
    {
        private readonly FakeClass fakeClass;

        public Class1(FakeClass fakeClass)
        {
            this.fakeClass = fakeClass;
        }

        public bool DoSomething()
        {
            return fakeClass.Teste();
        }
    }
}
