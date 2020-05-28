using Autofac.Extras.FakeItEasy;
using FakeItEasy;
using FakeItEasyConcrete;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class TestWithGenerate : TesteBase
    {
        [Test]
        public void TestMethod2()
        {
            var classe1 = _autoFake.Generate<Class1>();

            classe1.DoSomething();

            A.CallTo(() => _autoFake.Resolve<FakeClass>().Teste())
                .MustHaveHappenedOnceExactly();
        }
    }
}
