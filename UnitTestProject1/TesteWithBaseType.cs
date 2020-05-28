using FakeItEasy;
using FakeItEasyConcrete;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class TesteWithBaseType : TesteBase<Class1>
    {
        [Test]
        public void TestMethod1()
        {
            var classe1 = _autoFake.Resolve<Class1>();

            classe1.DoSomething();

            A.CallTo(() => _autoFake.Resolve<FakeClass>().Teste())
                .MustHaveHappenedOnceExactly();
        }
    }
}
