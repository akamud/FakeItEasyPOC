using Autofac;
using Autofac.Builder;
using Autofac.Extras.FakeItEasy;
using FakeItEasy;
using FakeItEasyConcrete;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var autoFake = RelaxedAutoFakeCreator.For<Class1>();
            var classe1 = autoFake.Resolve<Class1>();

            classe1.DoSomething();

            A.CallTo(() => autoFake.Resolve<FakeClass>().Teste())
                .MustHaveHappenedOnceExactly();
        }
    }
}
