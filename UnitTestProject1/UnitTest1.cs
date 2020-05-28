using System;
using Autofac;
using Autofac.Builder;
using Autofac.Extras.FakeItEasy;
using FakeItEasy;
using FakeItEasyConcrete;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class UnitTest1 : TesteBase<Class1>
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

    public class TesteBase<T>
    {
        protected AutoFake _autoFake;

        [SetUp]
        public void SetUp()
        {
            _autoFake = RelaxedAutoFakeCreator.For<T>();
        }

        [TearDown]
        public void TearDown()
        {
            _autoFake.Dispose();
        }
    }
}
